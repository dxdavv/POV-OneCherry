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
            titulo = new Label();
            textUsr = new Label();
            textPwd = new Label();
            btnLogin = new Button();
            btnSalir = new Button();
            imgPerrito = new PictureBox();
            inputUsr = new TextBox();
            inputPwd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)imgPerrito).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = SystemColors.ControlText;
            titulo.ImageAlign = ContentAlignment.TopCenter;
            titulo.Location = new Point(176, 15);
            titulo.MaximumSize = new Size(248, 37);
            titulo.MinimumSize = new Size(248, 37);
            titulo.Name = "titulo";
            titulo.Size = new Size(248, 37);
            titulo.TabIndex = 0;
            titulo.Text = "ONE CHERRY";
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textUsr
            // 
            textUsr.AutoSize = true;
            textUsr.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsr.Location = new Point(182, 120);
            textUsr.Name = "textUsr";
            textUsr.Size = new Size(116, 31);
            textUsr.TabIndex = 1;
            textUsr.Text = "Usuario:";
            // 
            // textPwd
            // 
            textPwd.AutoSize = true;
            textPwd.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPwd.Location = new Point(182, 185);
            textPwd.Name = "textPwd";
            textPwd.Size = new Size(163, 31);
            textPwd.TabIndex = 2;
            textPwd.Text = "Contraseña:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Crimson;
            btnLogin.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(355, 309);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 32);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btn_Login;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.OliveDrab;
            btnSalir.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(464, 309);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 32);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Exit";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btn_Salir;
            // 
            // imgPerrito
            // 
            imgPerrito.ErrorImage = (Image)resources.GetObject("imgPerrito.ErrorImage");
            imgPerrito.Image = Properties.Resources.perrito;
            imgPerrito.InitialImage = (Image)resources.GetObject("imgPerrito.InitialImage");
            imgPerrito.Location = new Point(25, 106);
            imgPerrito.MaximumSize = new Size(140, 121);
            imgPerrito.MinimumSize = new Size(140, 121);
            imgPerrito.Name = "imgPerrito";
            imgPerrito.Size = new Size(140, 121);
            imgPerrito.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPerrito.TabIndex = 5;
            imgPerrito.TabStop = false;
            // 
            // inputUsr
            // 
            inputUsr.BackColor = SystemColors.ButtonHighlight;
            inputUsr.ForeColor = SystemColors.WindowText;
            inputUsr.Location = new Point(286, 127);
            inputUsr.Name = "inputUsr";
            inputUsr.Size = new Size(151, 23);
            inputUsr.TabIndex = 6;
            // 
            // inputPwd
            // 
            inputPwd.BackColor = SystemColors.ButtonHighlight;
            inputPwd.Location = new Point(328, 193);
            inputPwd.Name = "inputPwd";
            inputPwd.Size = new Size(151, 23);
            inputPwd.TabIndex = 7;
            inputPwd.UseSystemPasswordChar = true;
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(584, 361);
            Controls.Add(inputPwd);
            Controls.Add(inputUsr);
            Controls.Add(imgPerrito);
            Controls.Add(btnSalir);
            Controls.Add(btnLogin);
            Controls.Add(textPwd);
            Controls.Add(textUsr);
            Controls.Add(titulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "LoginAdmin";
            Text = "Log in admin";
            ((System.ComponentModel.ISupportInitialize)imgPerrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label textUsr;
        private Label textPwd;
        private Button btnSalir;
        private PictureBox imgPerrito;
        protected internal Button btnLogin;
        private TextBox inputUsr;
        private TextBox inputPwd;
    }
}