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
            button12 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button10 = new Button();
            textBox1 = new TextBox();
            TablaCompras = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)TablaCompras).BeginInit();
            SuspendLayout();
            // 
            // button12
            // 
            button12.BackColor = Color.OliveDrab;
            button12.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.ForeColor = SystemColors.ControlLightLight;
            button12.Location = new Point(44, 337);
            button12.Name = "button12";
            button12.Size = new Size(193, 43);
            button12.TabIndex = 84;
            button12.Text = "⏬Descarga excel";
            button12.UseVisualStyleBackColor = false;
            button12.Click += ToExcel;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ID", "Fecha", "Proveedor", "Productos", "Cantidad", "Precio Unitario", "Precio Total" });
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
            button10.Click += Buscar;
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
            // VentanaComprasProv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(834, 391);
            Controls.Add(button12);
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

        private Button button12;
        private ComboBox comboBox1;
        private Label label2;
        private Button button10;
        private TextBox textBox1;
        private DataGridView TablaCompras;
        private Label label1;
    }
}