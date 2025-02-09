using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompProgPT
{
    public class RoundedPanels : Panel
    {
        //Fields
      private int borderRadius = 30;
        private float gradientAngle = 90f;
        private Color gradientTopColor = Color.Silver;
        private Color gradientBottomColor = Color.WhiteSmoke;

        //Constructors
       public RoundedPanels()
        { 
            this.BackColor= Color.Transparent;
            this.ForeColor= Color.Transparent;
            this.Size = new Size(450, 300);
        }

        //properties 
        public int BorderRadius
        {
            get => borderRadius;
            set {borderRadius = value; this.Invalidate();}
        }
        public float GradientAngle
        {
            get => gradientAngle;
            set {gradientAngle = value; this.Invalidate(); }
        }

        public Color GradientTopColor
        {
            get => gradientTopColor;
            set {gradientTopColor = value; this.Invalidate(); }
        }
        public Color GradientBottomColor 
        {
            get => gradientBottomColor;
            set {gradientBottomColor = value; this.Invalidate(); }
        }

      //Methods 
      private GraphicsPath GetRoundedPanels(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.Width - radius, rect.Height - radius,radius,radius,0,90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.CloseFigure();
            return path;
        }

        //Overridden Methods 
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Gradient
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.GradientTopColor, this.GradientBottomColor,  this.GradientAngle);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brush, ClientRectangle);

            //BorderRadius
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetRoundedPanels(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);
                }

            }
            else this.Region = new Region(rectangleF);
        }
    }
}
 