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
            label2 = new Label();
            adminButton = new Button();
            empleadoButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 20);
            label2.Name = "label2";
            label2.Size = new Size(245, 31);
            label2.TabIndex = 12;
            label2.Text = "Inicia sesión como:";
            // 
            // adminButton
            // 
            adminButton.BackColor = Color.Crimson;
            adminButton.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminButton.ForeColor = SystemColors.ControlLightLight;
            adminButton.Location = new Point(60, 68);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(115, 60);
            adminButton.TabIndex = 13;
            adminButton.Text = "Administrador";
            adminButton.UseVisualStyleBackColor = false;
            adminButton.Click += botonAdmin;
            // 
            // empleadoButton
            // 
            empleadoButton.BackColor = Color.Crimson;
            empleadoButton.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empleadoButton.ForeColor = SystemColors.ControlLightLight;
            empleadoButton.Location = new Point(210, 68);
            empleadoButton.Name = "empleadoButton";
            empleadoButton.Size = new Size(115, 60);
            empleadoButton.TabIndex = 14;
            empleadoButton.Text = "Empleado";
            empleadoButton.UseVisualStyleBackColor = false;
            empleadoButton.Click += botonEmpleado;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.OliveDrab;
            exitButton.Font = new Font("Sitka Heading", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.ForeColor = SystemColors.ControlLightLight;
            exitButton.Location = new Point(145, 165);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(110, 35);
            exitButton.TabIndex = 17;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += Salir;
            // 
            // PrimerPantallaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(384, 211);
            Controls.Add(exitButton);
            Controls.Add(empleadoButton);
            Controls.Add(adminButton);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PrimerPantallaLogin";
            Text = "LOG IN";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label2;
        protected internal Button adminButton;
        protected internal Button empleadoButton;
        protected internal Button exitButton;
    }
}