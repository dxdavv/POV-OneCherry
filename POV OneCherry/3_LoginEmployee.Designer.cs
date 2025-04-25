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
            pictureBox1 = new PictureBox();
            pwdInput = new TextBox();
            usrInput = new TextBox();
            exitButton = new Button();
            loginButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            // pwdInput
            // 
            pwdInput.BackColor = SystemColors.ButtonHighlight;
            pwdInput.Location = new Point(328, 202);
            pwdInput.Name = "pwdInput";
            pwdInput.Size = new Size(151, 23);
            pwdInput.TabIndex = 20;
            pwdInput.UseSystemPasswordChar = true;
            // 
            // usrInput
            // 
            usrInput.BackColor = SystemColors.ButtonHighlight;
            usrInput.ForeColor = SystemColors.WindowText;
            usrInput.Location = new Point(293, 129);
            usrInput.Name = "usrInput";
            usrInput.Size = new Size(151, 23);
            usrInput.TabIndex = 19;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.OliveDrab;
            exitButton.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.ForeColor = SystemColors.ControlLightLight;
            exitButton.Location = new Point(364, 264);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(100, 32);
            exitButton.TabIndex = 18;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += Salir;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Crimson;
            loginButton.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = SystemColors.ControlLightLight;
            loginButton.Location = new Point(470, 264);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 32);
            loginButton.TabIndex = 17;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += logIn;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(180, 189);
            label3.Name = "label3";
            label3.Size = new Size(153, 39);
            label3.TabIndex = 16;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(180, 121);
            label2.Name = "label2";
            label2.Size = new Size(112, 39);
            label2.TabIndex = 15;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(171, 10);
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
            ClientSize = new Size(584, 311);
            Controls.Add(pwdInput);
            Controls.Add(usrInput);
            Controls.Add(exitButton);
            Controls.Add(loginButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(600, 350);
            MinimumSize = new Size(600, 350);
            Name = "LoginEmpleado";
<<<<<<< HEAD
            Text = "Log in employee";
            // Load += LoginEmpleado_Load;
=======
            Text = "LOG IN EMPLOYEE";
>>>>>>> b83a3d0dc87083ca2956d2ff6849e91a1f8691a6
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox pwdInput;
        private TextBox usrInput;
        private Button exitButton;
        protected internal Button loginButton;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}