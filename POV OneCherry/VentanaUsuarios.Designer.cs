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
            TablaUsuarios = new DataGridView();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)TablaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 33);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 40;
            label2.Text = "Búsqueda por -›";
            // 
            // button10
            // 
            button10.BackColor = Color.Crimson;
            button10.Font = new Font("Sitka Banner", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(607, 29);
            button10.Name = "button10";
            button10.Size = new Size(102, 35);
            button10.TabIndex = 38;
            button10.Text = "🔎Buscar";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = false;
            button10.Click += Buscar;
            // 
            // button9
            // 
            button9.BackColor = Color.Crimson;
            button9.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(612, 371);
            button9.Name = "button9";
            button9.Size = new Size(161, 43);
            button9.TabIndex = 37;
            button9.Text = "🗑️Eliminar";
            button9.UseVisualStyleBackColor = false;
            button9.Click += Eliminar;
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(353, 371);
            button8.Name = "button8";
            button8.Size = new Size(161, 43);
            button8.TabIndex = 36;
            button8.Text = "🖋️Editar";
            button8.UseVisualStyleBackColor = false;
            button8.Click += Editar;
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(78, 371);
            button7.Name = "button7";
            button7.Size = new Size(161, 43);
            button7.TabIndex = 35;
            button7.Text = "📥Agregar";
            button7.UseVisualStyleBackColor = false;
            button7.Click += Agregar;
            // 
            // TablaUsuarios
            // 
            TablaUsuarios.AllowUserToAddRows = false;
            TablaUsuarios.AllowUserToDeleteRows = false;
            TablaUsuarios.BackgroundColor = SystemColors.ButtonHighlight;
            TablaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaUsuarios.Location = new Point(44, 70);
            TablaUsuarios.Name = "TablaUsuarios";
            TablaUsuarios.ReadOnly = true;
            TablaUsuarios.Size = new Size(750, 225);
            TablaUsuarios.TabIndex = 34;
            TablaUsuarios.CellDoubleClick += MandarAEditar;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, -7);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(147, 42);
            label1.TabIndex = 33;
            label1.Text = "USUARIOS";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 331);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 23);
            textBox2.TabIndex = 41;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(348, 331);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(284, 23);
            textBox3.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 303);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(74, 28);
            label3.TabIndex = 43;
            label3.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(348, 303);
            label5.Margin = new Padding(5);
            label5.Name = "label5";
            label5.Size = new Size(101, 28);
            label5.TabIndex = 44;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(662, 303);
            label4.Margin = new Padding(5);
            label4.Name = "label4";
            label4.Size = new Size(47, 28);
            label4.TabIndex = 46;
            label4.Text = "Tipo";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrador", "Empleado" });
            comboBox1.Location = new Point(662, 331);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 47;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Nombre de usuario", "Pin", "Tipo" });
            comboBox2.Location = new Point(199, 37);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(187, 23);
            comboBox2.TabIndex = 48;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(392, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 49;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(834, 421);
            Controls.Add(textBox1);
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
            Controls.Add(TablaUsuarios);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Usuarios";
            Text = "USUARIOS";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)TablaUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private DataGridView TablaUsuarios;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label5;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
    }
}