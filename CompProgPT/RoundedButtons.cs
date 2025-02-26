using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;

namespace CompProgPT
{
    public class RoundedButton : Button
    {
        //Fields 
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.White;

        public int BorderSize
        {
            get => borderSize;
            set {borderSize = value; this.Invalidate();}
        }
        public int BorderRadius
        {
            get => borderRadius;
            set {borderRadius = value;this.Invalidate();}
        }
        public Color BorderColor
        {
            get => borderColor;
            set {borderColor = value; this.Invalidate();}
        }

        //constructor
        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.White;   
            this.ForeColor = Color.Black;

        }

        //Methods 
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        { 
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y,radius, radius, 180,90);
            path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height-radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8f, this.Height - 1);

            if (borderRadius > 2) //RoundedButton
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    //ButtonSurface
                    this.Region = new Region(pathSurface);
                    //DrawSurface border for HD result
                    e.Graphics.DrawPath(penSurface, pathSurface);

                    //button border 
                    if (borderSize >= 1)
                    {
                        //Draw Control Border
                        e.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }

            else //Normal Button
            {
                //Button Surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            {
                base.OnHandleCreated(e);
                this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
            }
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    } 
}
