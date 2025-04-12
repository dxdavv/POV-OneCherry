namespace POV_OneCherry
{
    partial class LoginEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginEmpleado));
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pwdText = new TextBox();
            usrText = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(355, 309);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 9;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += logIn;
            // 
            // button2
            // 
            button2.BackColor = Color.OliveDrab;
            button2.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(464, 309);
            button2.Name = "button2";
            button2.Size = new Size(100, 32);
            button2.TabIndex = 10;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Salir;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(25, 106);
            pictureBox1.MaximumSize = new Size(140, 121);
            pictureBox1.MinimumSize = new Size(140, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pwdText
            // 
            pwdText.BackColor = SystemColors.ButtonHighlight;
            pwdText.Location = new Point(322, 196);
            pwdText.Name = "pwdText";
            pwdText.Size = new Size(151, 23);
            pwdText.TabIndex = 18;
            pwdText.UseSystemPasswordChar = true;
            // 
            // usrText
            // 
            usrText.BackColor = SystemColors.ButtonHighlight;
            usrText.ForeColor = SystemColors.WindowText;
            usrText.Location = new Point(280, 130);
            usrText.Name = "usrText";
            usrText.Size = new Size(151, 23);
            usrText.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(176, 188);
            label3.Name = "label3";
            label3.Size = new Size(163, 31);
            label3.TabIndex = 16;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(176, 123);
            label2.Name = "label2";
            label2.Size = new Size(116, 31);
            label2.TabIndex = 15;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(170, 18);
            label1.MaximumSize = new Size(248, 37);
            label1.MinimumSize = new Size(248, 37);
            label1.Name = "label1";
            label1.Size = new Size(248, 37);
            label1.TabIndex = 14;
            label1.Text = "ONE CHERRY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(584, 361);
            Controls.Add(pwdText);
            Controls.Add(usrText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "LoginEmpleado";
            Text = "LOG IN EMPLOYEE";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected internal Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox pwdText;
        private TextBox usrText;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}