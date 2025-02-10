namespace CompProgPT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            PW_Input = new TextBox();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            PW_Hidden = new Button();
            PW_Show = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Book Antiqua", 11.25F);
            textBox1.Location = new Point(204, 127);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 26);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(117, 19);
            label1.Name = "label1";
            label1.Size = new Size(271, 46);
            label1.TabIndex = 2;
            label1.Text = "Welcome Back!\r\n";
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Book Antiqua", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(91, 248);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(287, 34);
            button2.TabIndex = 3;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Book Antiqua", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(91, 127);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 4;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Book Antiqua", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(91, 195);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 5;
            label3.Text = "Password : ";
            // 
            // PW_Input
            // 
            PW_Input.Font = new Font("Book Antiqua", 11.25F);
            PW_Input.Location = new Point(204, 195);
            PW_Input.Margin = new Padding(3, 2, 3, 2);
            PW_Input.Name = "PW_Input";
            PW_Input.Size = new Size(152, 26);
            PW_Input.TabIndex = 6;
            PW_Input.UseSystemPasswordChar = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.FromArgb(0, 0, 192);
            linkLabel1.LinkColor = Color.FromArgb(0, 0, 192);
            linkLabel1.Location = new Point(157, 295);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(161, 16);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "No Account yet? Click Here!\r\n";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Book Antiqua", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(177, 65);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 14;
            label4.Text = "Log-in to continue\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(434, -52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(465, 537);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // PW_Hidden
            // 
            PW_Hidden.BackgroundImage = (Image)resources.GetObject("PW_Hidden.BackgroundImage");
            PW_Hidden.BackgroundImageLayout = ImageLayout.Stretch;
            PW_Hidden.Cursor = Cursors.Hand;
            PW_Hidden.Location = new Point(362, 191);
            PW_Hidden.Name = "PW_Hidden";
            PW_Hidden.Size = new Size(37, 36);
            PW_Hidden.TabIndex = 18;
            PW_Hidden.UseVisualStyleBackColor = true;
            PW_Hidden.Click += PW_Hidden_Click;
            // 
            // PW_Show
            // 
            PW_Show.BackgroundImage = (Image)resources.GetObject("PW_Show.BackgroundImage");
            PW_Show.BackgroundImageLayout = ImageLayout.Zoom;
            PW_Show.Cursor = Cursors.Hand;
            PW_Show.Location = new Point(362, 191);
            PW_Show.Name = "PW_Show";
            PW_Show.Size = new Size(37, 36);
            PW_Show.TabIndex = 19;
            PW_Show.UseVisualStyleBackColor = true;
            PW_Show.Click += PW_Show_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(894, 365);
            Controls.Add(PW_Hidden);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(PW_Input);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(PW_Show);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Login Page";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Label label3;
        private TextBox PW_Input;
        private LinkLabel linkLabel1;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button PW_Hidden;
        private Button PW_Show;
    }
}
