namespace POV_OneCherry
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
            comboBox1 = new ComboBox();
            label2 = new Label();
            button10 = new Button();
            textBox1 = new TextBox();
            TablaCompras = new DataGridView();
            label1 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)TablaCompras).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ID", "Fecha", "Proveedor" });
            comboBox1.Location = new Point(142, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 44);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 74;
            label2.Text = "Búsqueda por -›";
            // 
            // button10
            // 
            button10.BackColor = Color.Crimson;
            button10.Font = new Font("Sitka Banner", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(559, 41);
            button10.Name = "button10";
            button10.Size = new Size(102, 35);
            button10.TabIndex = 72;
            button10.Text = "🔎Buscar";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(269, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 23);
            textBox1.TabIndex = 73;
            // 
            // TablaCompras
            // 
            TablaCompras.AllowUserToAddRows = false;
            TablaCompras.AllowUserToDeleteRows = false;
            TablaCompras.BackgroundColor = SystemColors.ButtonHighlight;
            TablaCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaCompras.Location = new Point(44, 78);
            TablaCompras.Name = "TablaCompras";
            TablaCompras.ReadOnly = true;
            TablaCompras.Size = new Size(750, 253);
            TablaCompras.TabIndex = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 5);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(359, 42);
            label1.TabIndex = 67;
            label1.Text = "COMPRAS A PROVEEDORES";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(432, 340);
            label8.Margin = new Padding(5);
            label8.Name = "label8";
            label8.Size = new Size(93, 28);
            label8.TabIndex = 92;
            label8.Text = "Proveedor";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(432, 368);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 23);
            textBox5.TabIndex = 91;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(241, 340);
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
            label7.Location = new Point(45, 340);
            label7.Margin = new Padding(5);
            label7.Name = "label7";
            label7.Size = new Size(82, 28);
            label7.TabIndex = 87;
            label7.Text = "Producto";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(241, 368);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 85;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(45, 368);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 23);
            textBox2.TabIndex = 86;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(637, 352);
            button3.Name = "button3";
            button3.Size = new Size(157, 39);
            button3.TabIndex = 93;
            button3.Text = "Solicitar compra";
            button3.UseVisualStyleBackColor = false;
            // 
            // VentanaComprasProv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(834, 411);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(button10);
            Controls.Add(textBox1);
            Controls.Add(TablaCompras);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "VentanaComprasProv";
            Text = "COMPRAS";
            Load += VentanaComprasProv_Load;
            ((System.ComponentModel.ISupportInitialize)TablaCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label label2;
        private Button button10;
        private TextBox textBox1;
        private DataGridView TablaCompras;
        private Label label1;
        private Label label8;
        private TextBox textBox5;
        private Label label5;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button3;
    }
}