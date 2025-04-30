namespace POV_OneCherry
{
    partial class LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            loginButton = new Button();
            exitButton = new Button();
            imagenPerrito = new PictureBox();
            usrInput = new TextBox();
            pwdInput = new TextBox();
            ((System.ComponentModel.ISupportInitialize)imagenPerrito).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(173, 9);
            label1.MaximumSize = new Size(248, 37);
            label1.MinimumSize = new Size(248, 37);
            label1.Name = "label1";
            label1.Size = new Size(248, 37);
            label1.TabIndex = 0;
            label1.Text = "ONE CHERRY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(182, 120);
            label2.Name = "label2";
            label2.Size = new Size(112, 39);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(182, 188);
            label3.Name = "label3";
            label3.Size = new Size(153, 39);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Crimson;
            loginButton.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = SystemColors.ControlLightLight;
            loginButton.Location = new Point(472, 263);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 32);
            loginButton.TabIndex = 3;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += logIn;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.OliveDrab;
            exitButton.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.ForeColor = SystemColors.ControlLightLight;
            exitButton.Location = new Point(366, 263);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(100, 32);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += Salir;
            // 
            // imagenPerrito
            // 
            imagenPerrito.ErrorImage = (Image)resources.GetObject("imagenPerrito.ErrorImage");
            imagenPerrito.Image = (Image)resources.GetObject("imagenPerrito.Image");
            imagenPerrito.InitialImage = (Image)resources.GetObject("imagenPerrito.InitialImage");
            imagenPerrito.Location = new Point(25, 86);
            imagenPerrito.MaximumSize = new Size(140, 121);
            imagenPerrito.MinimumSize = new Size(140, 121);
            imagenPerrito.Name = "imagenPerrito";
            imagenPerrito.Size = new Size(140, 121);
            imagenPerrito.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenPerrito.TabIndex = 5;
            imagenPerrito.TabStop = false;
            // 
            // usrInput
            // 
            usrInput.BackColor = SystemColors.ButtonHighlight;
            usrInput.ForeColor = SystemColors.WindowText;
            usrInput.Location = new Point(295, 128);
            usrInput.Name = "usrInput";
            usrInput.Size = new Size(151, 23);
            usrInput.TabIndex = 6;
            // 
            // pwdInput
            // 
            pwdInput.BackColor = SystemColors.ButtonHighlight;
            pwdInput.Location = new Point(330, 201);
            pwdInput.Name = "pwdInput";
            pwdInput.Size = new Size(151, 23);
            pwdInput.TabIndex = 7;
            pwdInput.UseSystemPasswordChar = true;
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(584, 311);
            Controls.Add(pwdInput);
            Controls.Add(usrInput);
            Controls.Add(imagenPerrito);
            Controls.Add(exitButton);
            Controls.Add(loginButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(600, 350);
            MinimumSize = new Size(600, 350);
            Name = "LoginAdmin";
            Text = "LOG IN ADMIN";
            ((System.ComponentModel.ISupportInitialize)imagenPerrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button exitButton;
        private PictureBox imagenPerrito;
        protected internal Button loginButton;
        private TextBox usrInput;
        private TextBox pwdInput;
    }
}