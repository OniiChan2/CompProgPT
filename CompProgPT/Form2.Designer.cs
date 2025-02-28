namespace CompProgPT
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            username = new TextBox();
            Pw_Input = new TextBox();
            Pw_Input2 = new TextBox();
            email = new TextBox();
            phonenum = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            PW_Hidden = new Button();
            PW_Show = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.Font = new Font("Book Antiqua", 11.25F);
            username.Location = new Point(199, 116);
            username.Margin = new Padding(3, 2, 3, 2);
            username.Name = "username";
            username.Size = new Size(177, 26);
            username.TabIndex = 1;
            // 
            // Pw_Input
            // 
            Pw_Input.Font = new Font("Book Antiqua", 11.25F);
            Pw_Input.Location = new Point(199, 151);
            Pw_Input.Margin = new Padding(3, 2, 3, 2);
            Pw_Input.Name = "Pw_Input";
            Pw_Input.Size = new Size(177, 26);
            Pw_Input.TabIndex = 2;
            Pw_Input.UseSystemPasswordChar = true;
            // 
            // Pw_Input2
            // 
            Pw_Input2.Font = new Font("Book Antiqua", 11.25F);
            Pw_Input2.Location = new Point(199, 191);
            Pw_Input2.Margin = new Padding(3, 2, 3, 2);
            Pw_Input2.Name = "Pw_Input2";
            Pw_Input2.Size = new Size(177, 26);
            Pw_Input2.TabIndex = 3;
            Pw_Input2.UseSystemPasswordChar = true;
            // 
            // email
            // 
            email.Font = new Font("Book Antiqua", 11.25F);
            email.Location = new Point(199, 232);
            email.Margin = new Padding(3, 2, 3, 2);
            email.Name = "email";
            email.Size = new Size(177, 26);
            email.TabIndex = 4;
            // 
            // phonenum
            // 
            phonenum.Font = new Font("Book Antiqua", 11.25F);
            phonenum.Location = new Point(199, 270);
            phonenum.Margin = new Padding(3, 2, 3, 2);
            phonenum.Name = "phonenum";
            phonenum.Size = new Size(177, 26);
            phonenum.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 11.25F);
            label2.Location = new Point(98, 119);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 6;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 11.25F);
            label3.Location = new Point(98, 155);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 7;
            label3.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 11.25F);
            label4.Location = new Point(38, 191);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 8;
            label4.Text = "Confirm Password :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 11.25F);
            label5.Location = new Point(116, 235);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 9;
            label5.Text = "E-mail :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 11.25F);
            label6.Location = new Point(65, 273);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 10;
            label6.Text = "Phone Number :";
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(98, 305);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(315, 31);
            button1.TabIndex = 12;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(149, 347);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(215, 17);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already Have Account? Click Here!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(453, -55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(468, 525);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 20);
            label1.Name = "label1";
            label1.Size = new Size(142, 41);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(199, 70);
            label7.Name = "label7";
            label7.Size = new Size(139, 20);
            label7.TabIndex = 16;
            label7.Text = "Sign up to continue";
            // 
            // PW_Hidden
            // 
            PW_Hidden.BackgroundImage = (Image)resources.GetObject("PW_Hidden.BackgroundImage");
            PW_Hidden.BackgroundImageLayout = ImageLayout.Stretch;
            PW_Hidden.Cursor = Cursors.Hand;
            PW_Hidden.Location = new Point(382, 148);
            PW_Hidden.Name = "PW_Hidden";
            PW_Hidden.Size = new Size(37, 36);
            PW_Hidden.TabIndex = 17;
            PW_Hidden.UseVisualStyleBackColor = true;
            PW_Hidden.Click += PW_Hidden_Click;
            // 
            // PW_Show
            // 
            PW_Show.BackgroundImage = (Image)resources.GetObject("PW_Show.BackgroundImage");
            PW_Show.BackgroundImageLayout = ImageLayout.Zoom;
            PW_Show.Cursor = Cursors.Hand;
            PW_Show.Location = new Point(382, 147);
            PW_Show.Name = "PW_Show";
            PW_Show.Size = new Size(37, 36);
            PW_Show.TabIndex = 18;
            PW_Show.UseVisualStyleBackColor = true;
            PW_Show.Click += PW_Show_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 386);
            Controls.Add(PW_Hidden);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(phonenum);
            Controls.Add(email);
            Controls.Add(Pw_Input2);
            Controls.Add(Pw_Input);
            Controls.Add(username);
            Controls.Add(label1);
            Controls.Add(PW_Show);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Sign Up Page";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox username;
        private TextBox Pw_Input;
        private TextBox Pw_Input2;
        private TextBox email;
        private TextBox phonenum;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label7;
        private Button PW_Hidden;
        private Button PW_Show;
    }
}