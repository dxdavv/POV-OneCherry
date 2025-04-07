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
            inputUsr = new TextBox();
            inputPwd = new TextBox();
            btnLogin = new Button();
            btnSalir = new Button();
            txtUsr = new Label();
            txtPwd = new Label();
            imgGatito = new PictureBox();
            titulo = new Label();
            ((System.ComponentModel.ISupportInitialize)imgGatito).BeginInit();
            SuspendLayout();
            // 
            // inputUsr
            // 
            inputUsr.BackColor = SystemColors.ButtonHighlight;
            inputUsr.Location = new Point(304, 127);
            inputUsr.Name = "inputUsr";
            inputUsr.Size = new Size(133, 23);
            inputUsr.TabIndex = 7;
            // 
            // inputPwd
            // 
            inputPwd.BackColor = SystemColors.ButtonHighlight;
            inputPwd.Location = new Point(351, 193);
            inputPwd.Name = "inputPwd";
            inputPwd.Size = new Size(128, 23);
            inputPwd.TabIndex = 8;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Crimson;
            btnLogin.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(355, 309);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 32);
            btnLogin.TabIndex = 9;
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
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Exit";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btn_Salir;
            // 
            // txtUsr
            // 
            txtUsr.AutoSize = true;
            txtUsr.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsr.Location = new Point(182, 120);
            txtUsr.Name = "txtUsr";
            txtUsr.Size = new Size(116, 31);
            txtUsr.TabIndex = 11;
            txtUsr.Text = "Usuario:";
            // 
            // txtPwd
            // 
            txtPwd.AutoSize = true;
            txtPwd.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPwd.Location = new Point(182, 185);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(163, 31);
            txtPwd.TabIndex = 12;
            txtPwd.Text = "Contraseña:";
            // 
            // imgGatito
            // 
            imgGatito.ErrorImage = (Image)resources.GetObject("imgGatito.ErrorImage");
            imgGatito.Image = (Image)resources.GetObject("imgGatito.Image");
            imgGatito.InitialImage = (Image)resources.GetObject("imgGatito.InitialImage");
            imgGatito.Location = new Point(25, 106);
            imgGatito.MaximumSize = new Size(140, 121);
            imgGatito.MinimumSize = new Size(140, 121);
            imgGatito.Name = "imgGatito";
            imgGatito.Size = new Size(140, 121);
            imgGatito.SizeMode = PictureBoxSizeMode.StretchImage;
            imgGatito.TabIndex = 13;
            imgGatito.TabStop = false;
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
            titulo.TabIndex = 14;
            titulo.Text = "ONE CHERRY";
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(584, 361);
            Controls.Add(titulo);
            Controls.Add(imgGatito);
            Controls.Add(txtPwd);
            Controls.Add(txtUsr);
            Controls.Add(btnSalir);
            Controls.Add(btnLogin);
            Controls.Add(inputPwd);
            Controls.Add(inputUsr);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "LoginEmpleado";
            Text = "Log in employee";
            ((System.ComponentModel.ISupportInitialize)imgGatito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputUsr;
        private TextBox inputPwd;
        protected internal Button btnLogin;
        private Button btnSalir;
        private Label txtUsr;
        private Label txtPwd;
        private PictureBox imgGatito;
        private Label titulo;
    }
}