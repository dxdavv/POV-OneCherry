namespace POV_OneCherry
{
    partial class VentanaFacturas
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
            comboBox1 = new ComboBox();
            label2 = new Label();
            button10 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button7 = new Button();
            label1 = new Label();
            ID_venta = new DataGridViewTextBoxColumn();
            Fecha_venta = new DataGridViewTextBoxColumn();
            Productos_venta = new DataGridViewTextBoxColumn();
            Precio_uni = new DataGridViewTextBoxColumn();
            Cantidad_venta = new DataGridViewTextBoxColumn();
            Precio_total_venta = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ID" });
            comboBox1.Location = new Point(163, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 43);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(133, 28);
            label2.TabIndex = 38;
            label2.Text = "Buscar venta -›";
            // 
            // button10
            // 
            button10.BackColor = Color.Crimson;
            button10.Font = new Font("Sitka Banner", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(580, 40);
            button10.Name = "button10";
            button10.Size = new Size(102, 35);
            button10.TabIndex = 36;
            button10.Text = "🔎Buscar";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(290, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 23);
            textBox1.TabIndex = 37;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_venta, Fecha_venta, Productos_venta, Precio_uni, Cantidad_venta, Precio_total_venta });
            dataGridView1.Location = new Point(24, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(658, 253);
            dataGridView1.TabIndex = 35;
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(24, 336);
            button7.Name = "button7";
            button7.Size = new Size(161, 43);
            button7.TabIndex = 40;
            button7.Text = "Generar factura";
            button7.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(259, 10);
            label1.Name = "label1";
            label1.Size = new Size(136, 35);
            label1.TabIndex = 42;
            label1.Text = "Elegir venta";
            // 
            // ID_venta
            // 
            ID_venta.HeaderText = "ID";
            ID_venta.Name = "ID_venta";
            ID_venta.ReadOnly = true;
            ID_venta.Width = 50;
            // 
            // Fecha_venta
            // 
            Fecha_venta.HeaderText = "Fecha";
            Fecha_venta.Name = "Fecha_venta";
            Fecha_venta.ReadOnly = true;
            Fecha_venta.Width = 120;
            // 
            // Productos_venta
            // 
            Productos_venta.HeaderText = "Productos";
            Productos_venta.Name = "Productos_venta";
            Productos_venta.ReadOnly = true;
            Productos_venta.Width = 150;
            // 
            // Precio_uni
            // 
            Precio_uni.HeaderText = "Precio";
            Precio_uni.Name = "Precio_uni";
            Precio_uni.ReadOnly = true;
            // 
            // Cantidad_venta
            // 
            Cantidad_venta.HeaderText = "Cantidad";
            Cantidad_venta.Name = "Cantidad_venta";
            Cantidad_venta.ReadOnly = true;
            // 
            // Precio_total_venta
            // 
            Precio_total_venta.HeaderText = "Precio total";
            Precio_total_venta.Name = "Precio_total_venta";
            Precio_total_venta.ReadOnly = true;
            // 
            // VentanaFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(734, 411);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(button10);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "VentanaFacturas";
            Text = "FACTURAS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label2;
        private Button button10;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button7;
        private Label label1;
        private DataGridViewTextBoxColumn ID_venta;
        private DataGridViewTextBoxColumn Fecha_venta;
        private DataGridViewTextBoxColumn Productos_venta;
        private DataGridViewTextBoxColumn Precio_uni;
        private DataGridViewTextBoxColumn Cantidad_venta;
        private DataGridViewTextBoxColumn Precio_total_venta;
    }
}