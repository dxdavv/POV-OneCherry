namespace POV_OneCherry
{
    partial class RegistroCliente
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
            label1 = new Label();
            inputNombre = new TextBox();
            txtNombre = new Label();
            txtApellido = new Label();
            txtEmail = new Label();
            txtTel = new Label();
            inputEmail = new TextBox();
            inputTel = new TextBox();
            inputApellido = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 37);
            label1.TabIndex = 0;
            label1.Text = "Registrar cliente";
            // 
            // inputNombre
            // 
            inputNombre.Location = new Point(77, 94);
            inputNombre.Name = "inputNombre";
            inputNombre.Size = new Size(240, 23);
            inputNombre.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(154, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(84, 24);
            txtNombre.TabIndex = 2;
            txtNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            txtApellido.AutoSize = true;
            txtApellido.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(154, 149);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(84, 24);
            txtApellido.TabIndex = 3;
            txtApellido.Text = "Apellido:";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(154, 304);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(62, 24);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "Email:";
            // 
            // txtTel
            // 
            txtTel.AutoSize = true;
            txtTel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTel.Location = new Point(151, 226);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(90, 24);
            txtTel.TabIndex = 5;
            txtTel.Text = "Telefono:";
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(60, 329);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(271, 23);
            inputEmail.TabIndex = 6;
            // 
            // inputTel
            // 
            inputTel.Location = new Point(77, 251);
            inputTel.Name = "inputTel";
            inputTel.Size = new Size(240, 23);
            inputTel.TabIndex = 7;
            // 
            // inputApellido
            // 
            inputApellido.Location = new Point(77, 174);
            inputApellido.Name = "inputApellido";
            inputApellido.Size = new Size(240, 23);
            inputApellido.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Crimson;
            btnAgregar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(150, 364);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 35);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // RegistroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(384, 411);
            Controls.Add(btnAgregar);
            Controls.Add(inputApellido);
            Controls.Add(inputTel);
            Controls.Add(inputEmail);
            Controls.Add(txtTel);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(inputNombre);
            Controls.Add(label1);
            Name = "RegistroCliente";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputNombre;
        private Label txtNombre;
        private Label txtApellido;
        private Label txtEmail;
        private Label txtTel;
        private TextBox inputEmail;
        private TextBox inputTel;
        private TextBox inputApellido;
        private Button btnAgregar;
    }
}