﻿namespace POV_OneCherry
{
    partial class VentanaProductos
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
            ListaProductos = new DataGridView();
            ID_producto = new DataGridViewTextBoxColumn();
            Nombre_producto = new DataGridViewTextBoxColumn();
            Precio_producto = new DataGridViewTextBoxColumn();
            Categoria_producto = new DataGridViewTextBoxColumn();
            Stock_producto = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button10 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            textBox5 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)ListaProductos).BeginInit();
            SuspendLayout();
            // 
            // ListaProductos
            //
            ListaProductos.AllowUserToAddRows = false;
            ListaProductos.AllowUserToDeleteRows = false;
            ListaProductos.BackgroundColor = SystemColors.ButtonHighlight;
            ListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaProductos.Columns.AddRange(new DataGridViewColumn[] { ID_producto, Nombre_producto, Precio_producto, Categoria_producto, Stock_producto });
            ListaProductos.Location = new Point(14, 111);
            ListaProductos.Margin = new Padding(3, 4, 3, 4);
            ListaProductos.Name = "ListaProductos";
            ListaProductos.ReadOnly = true;
            ListaProductos.RowHeadersWidth = 51;
            ListaProductos.Size = new Size(886, 236);
            ListaProductos.TabIndex = 0;
            // 
            // ID_producto
            // 
            ID_producto.HeaderText = "ID";
            ID_producto.MinimumWidth = 6;
            ID_producto.Name = "ID_producto";
            ID_producto.ReadOnly = true;
            ID_producto.Width = 50;
            // 
            // Nombre_producto
            // 
            Nombre_producto.HeaderText = "Nombre";
            Nombre_producto.MinimumWidth = 6;
            Nombre_producto.Name = "Nombre_producto";
            Nombre_producto.ReadOnly = true;
            Nombre_producto.Width = 200;
            // 
            // Precio_producto
            // 
            Precio_producto.HeaderText = "Precio";
            Precio_producto.MinimumWidth = 6;
            Precio_producto.Name = "Precio_producto";
            Precio_producto.ReadOnly = true;
            Precio_producto.Width = 200;
            // 
            // Categoria_producto
            // 
            Categoria_producto.HeaderText = "Categoría";
            Categoria_producto.MinimumWidth = 6;
            Categoria_producto.Name = "Categoria_producto";
            Categoria_producto.ReadOnly = true;
            Categoria_producto.Width = 200;
            // 
            // Stock_producto
            // 
            Stock_producto.HeaderText = "Stock";
            Stock_producto.MinimumWidth = 6;
            Stock_producto.Name = "Stock_producto";
            Stock_producto.ReadOnly = true;
            Stock_producto.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, -5);
            label1.Name = "label1";
            label1.Size = new Size(248, 43);
            label1.TabIndex = 1;
            label1.Text = "Lista de Productos";
            // 
            // button9
            // 
            button9.BackColor = Color.Crimson;
            button9.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(670, 527);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(184, 57);
            button9.TabIndex = 28;
            button9.Text = "🗑️Eliminar";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(374, 527);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(184, 57);
            button8.TabIndex = 27;
            button8.Text = "🖋️Editar";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(59, 527);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(184, 57);
            button7.TabIndex = 26;
            button7.Text = "📥Agregar";
            button7.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ID", "Nombre", "Teléfono", "Email" });
            comboBox1.Location = new Point(210, 67);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 60);
            label2.Margin = new Padding(6, 7, 6, 7);
            label2.Name = "label2";
            label2.Size = new Size(176, 35);
            label2.TabIndex = 33;
            label2.Text = "Búsqueda por -›";
            // 
            // button10
            // 
            button10.BackColor = Color.Crimson;
            button10.Font = new Font("Sitka Banner", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(687, 56);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(117, 47);
            button10.TabIndex = 31;
            button10.Text = "🔎Buscar";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(355, 67);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 27);
            textBox1.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(361, 357);
            label5.Margin = new Padding(6, 7, 6, 7);
            label5.Name = "label5";
            label5.Size = new Size(78, 35);
            label5.TabIndex = 48;
            label5.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 357);
            label3.Margin = new Padding(6, 7, 6, 7);
            label3.Name = "label3";
            label3.Size = new Size(96, 35);
            label3.TabIndex = 47;
            label3.Text = "Nombre";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(361, 395);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(196, 27);
            textBox3.TabIndex = 46;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 395);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(324, 27);
            textBox2.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(361, 436);
            label4.Margin = new Padding(6, 7, 6, 7);
            label4.Name = "label4";
            label4.Size = new Size(69, 35);
            label4.TabIndex = 52;
            label4.Text = "Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 436);
            label6.Margin = new Padding(6, 7, 6, 7);
            label6.Name = "label6";
            label6.Size = new Size(111, 35);
            label6.TabIndex = 51;
            label6.Text = "Categoría";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(361, 473);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(196, 27);
            textBox4.TabIndex = 50;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ID", "Nombre", "Teléfono", "Email" });
            comboBox2.Location = new Point(14, 473);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(324, 28);
            comboBox2.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(657, 357);
            label7.Margin = new Padding(6, 7, 6, 7);
            label7.Name = "label7";
            label7.Size = new Size(193, 35);
            label7.TabIndex = 55;
            label7.Text = "Agregar categoría";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(657, 395);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(173, 27);
            textBox5.TabIndex = 54;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(838, 387);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(34, 40);
            button4.TabIndex = 56;
            button4.Text = "+";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            // 
            // VentanaProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(913, 601);
            Controls.Add(button4);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(button10);
            Controls.Add(textBox1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(ListaProductos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "VentanaProductos";
            Text = "PRODUCTOS";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)ListaProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ListaProductos;
        private Label label1;
        private Button button9;
        private Button button8;
        private Button button7;
        private ComboBox comboBox1;
        private Label label2;
        private Button button10;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn ID_producto;
        private DataGridViewTextBoxColumn Nombre_producto;
        private DataGridViewTextBoxColumn Precio_producto;
        private DataGridViewTextBoxColumn Categoria_producto;
        private DataGridViewTextBoxColumn Stock_producto;
        private Label label5;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label6;
        private TextBox textBox4;
        private ComboBox comboBox2;
        private Label label7;
        private TextBox textBox5;
        private Button button4;
    }
}