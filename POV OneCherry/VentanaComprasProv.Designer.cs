﻿namespace POV_OneCherry
{
    partial class VentanaComprasProv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaComprasProv));
            TablaSolicitarCompras = new DataGridView();
            label1 = new Label();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            button3 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            textBox1 = new TextBox();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)TablaSolicitarCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TablaSolicitarCompras
            // 
            TablaSolicitarCompras.AllowUserToAddRows = false;
            TablaSolicitarCompras.AllowUserToDeleteRows = false;
            TablaSolicitarCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TablaSolicitarCompras.BackgroundColor = SystemColors.ButtonHighlight;
            TablaSolicitarCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaSolicitarCompras.Columns.AddRange(new DataGridViewColumn[] { Producto, Cantidad, Precio, Subtotal });
            TablaSolicitarCompras.Location = new Point(25, 108);
            TablaSolicitarCompras.Name = "TablaSolicitarCompras";
            TablaSolicitarCompras.ReadOnly = true;
            TablaSolicitarCompras.Size = new Size(599, 253);
            TablaSolicitarCompras.TabIndex = 68;
            TablaSolicitarCompras.CellDoubleClick += MandarAEliminarProductos;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 6);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(322, 42);
            label1.TabIndex = 67;
            label1.Text = "SOLICITAR PRODUCTOS ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 51);
            label8.Margin = new Padding(5);
            label8.Name = "label8";
            label8.Size = new Size(93, 28);
            label8.TabIndex = 92;
            label8.Text = "Proveedor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(440, 51);
            label5.Margin = new Padding(5);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 88;
            label5.Text = "Cantidad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(204, 51);
            label7.Margin = new Padding(5);
            label7.Name = "label7";
            label7.Size = new Size(82, 28);
            label7.TabIndex = 87;
            label7.Text = "Producto";
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(467, 367);
            button3.Name = "button3";
            button3.Size = new Size(157, 39);
            button3.TabIndex = 93;
            button3.Text = "Solicitar compra";
            button3.UseVisualStyleBackColor = false;
            button3.Click += solicitarStock;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(25, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 23);
            comboBox1.TabIndex = 94;
            comboBox1.SelectedIndexChanged += seleccionarProveedor;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(204, 81);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(139, 23);
            comboBox2.TabIndex = 95;
            comboBox2.SelectedIndexChanged += seleccionarProducto;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(440, 81);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(88, 23);
            numericUpDown1.TabIndex = 96;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(534, 74);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.TabIndex = 97;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AgregarProductoCompra;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(161, 367);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 98;
            button2.Text = "↪️";
            button2.UseVisualStyleBackColor = false;
            button2.Click += botonListaCompras;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 369);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(137, 21);
            label2.TabIndex = 99;
            label2.Text = "Ir a lista de compras";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 100;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(349, 51);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 101;
            label3.Text = "Precio";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(349, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(85, 23);
            textBox1.TabIndex = 102;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // VentanaComprasProv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(634, 411);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(TablaSolicitarCompras);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "VentanaComprasProv";
            ((System.ComponentModel.ISupportInitialize)TablaSolicitarCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView TablaSolicitarCompras;
        private Label label1;
        private Label label8;
        private Label label5;
        private Label label7;
        private Button button3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Subtotal;
    }
}