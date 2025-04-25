namespace POV_OneCherry
{
    partial class Usuarios
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
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            Usuraio = new DataGridView();
            Usuario_us = new DataGridViewTextBoxColumn();
            password_us = new DataGridViewTextBoxColumn();
            Tipo_usuario = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)Usuraio).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 44);
            label2.Margin = new Padding(6, 7, 6, 7);
            label2.Name = "label2";
            label2.Size = new Size(176, 35);
            label2.TabIndex = 40;
            label2.Text = "Búsqueda por -›";
            // 
            // button10
            // 
            button10.BackColor = Color.Crimson;
            button10.Font = new Font("Sitka Banner", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(547, 43);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(117, 47);
            button10.TabIndex = 38;
            button10.Text = "🔎Buscar";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Crimson;
            button9.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(699, 495);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(184, 57);
            button9.TabIndex = 37;
            button9.Text = "🗑️Eliminar";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(403, 495);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(184, 57);
            button8.TabIndex = 36;
            button8.Text = "🖋️Editar";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(89, 495);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(184, 57);
            button7.TabIndex = 35;
            button7.Text = "📥Agregar";
            button7.UseVisualStyleBackColor = false;
            // 
            // Usuraio
            // 
            Usuraio.AllowUserToAddRows = false;
            Usuraio.AllowUserToDeleteRows = false;
            Usuraio.BackgroundColor = SystemColors.ButtonHighlight;
            Usuraio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Usuraio.Columns.AddRange(new DataGridViewColumn[] { Usuario_us, password_us, Tipo_usuario });
            Usuraio.Location = new Point(50, 93);
            Usuraio.Margin = new Padding(3, 4, 3, 4);
            Usuraio.Name = "Usuraio";
            Usuraio.ReadOnly = true;
            Usuraio.RowHeadersWidth = 51;
            Usuraio.Size = new Size(857, 300);
            Usuraio.TabIndex = 34;
            // 
            // Usuario_us
            // 
            Usuario_us.HeaderText = "Usuario";
            Usuario_us.MinimumWidth = 6;
            Usuario_us.Name = "Usuario_us";
            Usuario_us.ReadOnly = true;
            Usuario_us.Width = 300;
            // 
            // password_us
            // 
            password_us.HeaderText = "Contraseña";
            password_us.MinimumWidth = 6;
            password_us.Name = "password_us";
            password_us.ReadOnly = true;
            password_us.Width = 300;
            // 
            // Tipo_usuario
            // 
            Tipo_usuario.HeaderText = "Tipo";
            Tipo_usuario.MinimumWidth = 6;
            Tipo_usuario.Name = "Tipo_usuario";
            Tipo_usuario.ReadOnly = true;
            Tipo_usuario.Width = 110;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, -9);
            label1.Margin = new Padding(6, 7, 6, 7);
            label1.Name = "label1";
            label1.Size = new Size(188, 53);
            label1.TabIndex = 33;
            label1.Text = "USUARIOS";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 441);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(324, 27);
            textBox2.TabIndex = 41;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(398, 441);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(324, 27);
            textBox3.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 404);
            label3.Margin = new Padding(6, 7, 6, 7);
            label3.Name = "label3";
            label3.Size = new Size(94, 35);
            label3.TabIndex = 43;
            label3.Text = "Usuario";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(398, 404);
            label5.Margin = new Padding(6, 7, 6, 7);
            label5.Name = "label5";
            label5.Size = new Size(128, 35);
            label5.TabIndex = 44;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(757, 404);
            label4.Margin = new Padding(6, 7, 6, 7);
            label4.Name = "label4";
            label4.Size = new Size(61, 35);
            label4.TabIndex = 46;
            label4.Text = "Tipo";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrador", "Empleado" });
            comboBox1.Location = new Point(757, 441);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 47;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Nombre de usuario", "Tipo" });
            comboBox2.Location = new Point(227, 49);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(313, 28);
            comboBox2.TabIndex = 48;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(953, 561);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(Usuraio);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Usuarios";
            Text = "USUARIOS";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)Usuraio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private DataGridView Usuraio;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label5;
        private DataGridViewTextBoxColumn Usuario_us;
        private DataGridViewTextBoxColumn password_us;
        private DataGridViewTextBoxColumn Tipo_usuario;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}