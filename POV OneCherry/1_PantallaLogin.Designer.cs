namespace POV_OneCherry
{
    partial class PrimerPantallaLogin
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
            textIniciarSesion = new Label();
            btnAdmin = new Button();
            btnEmpleado = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // textIniciarSesion
            // 
            textIniciarSesion.AutoSize = true;
            textIniciarSesion.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textIniciarSesion.Location = new Point(90, 20);
            textIniciarSesion.Name = "textIniciarSesion";
            textIniciarSesion.Size = new Size(245, 31);
            textIniciarSesion.TabIndex = 12;
            textIniciarSesion.Text = "Inicia sesión como:";
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Crimson;
            btnAdmin.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = SystemColors.ControlLightLight;
            btnAdmin.Location = new Point(60, 68);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(115, 60);
            btnAdmin.TabIndex = 13;
            btnAdmin.Text = "Administrador";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btn_admin;
            // 
            // btnEmpleado
            // 
            btnEmpleado.BackColor = Color.Crimson;
            btnEmpleado.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmpleado.ForeColor = SystemColors.ControlLightLight;
            btnEmpleado.Location = new Point(210, 68);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(115, 60);
            btnEmpleado.TabIndex = 14;
            btnEmpleado.Text = "Empleado";
            btnEmpleado.UseVisualStyleBackColor = false;
            btnEmpleado.Click += btn_empleado;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.OliveDrab;
            btnSalir.Font = new Font("Sitka Heading", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(145, 165);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 35);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Exit";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btn_salir;
            // 
            // PrimerPantallaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(384, 211);
            Controls.Add(btnSalir);
            Controls.Add(btnEmpleado);
            Controls.Add(btnAdmin);
            Controls.Add(textIniciarSesion);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PrimerPantallaLogin";
            Text = "LOG IN";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label textIniciarSesion;
        protected internal Button btnAdmin;
        protected internal Button btnEmpleado;
        protected internal Button btnSalir;
    }
}