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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaFacturas));
            comboBox1 = new ComboBox();
            label2 = new Label();
            button10 = new Button();
            textBox1 = new TextBox();
            TablaFacturas = new DataGridView();
            button7 = new Button();
            label1 = new Label();
            label3 = new Label();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TablaFacturas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(163, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 39;
            comboBox1.SelectedIndexChanged += OnChagedIndex;
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
            button10.Click += Buscar;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(290, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 23);
            textBox1.TabIndex = 37;
            // 
            // TablaFacturas
            // 
            TablaFacturas.AllowUserToAddRows = false;
            TablaFacturas.AllowUserToDeleteRows = false;
            TablaFacturas.BackgroundColor = SystemColors.ButtonHighlight;
            TablaFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaFacturas.Location = new Point(24, 81);
            TablaFacturas.Name = "TablaFacturas";
            TablaFacturas.ReadOnly = true;
            TablaFacturas.Size = new Size(676, 253);
            TablaFacturas.TabIndex = 35;
            TablaFacturas.CellDoubleClick += CargarVenta;
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(539, 340);
            button7.Name = "button7";
            button7.Size = new Size(161, 43);
            button7.TabIndex = 40;
            button7.Text = "⏬Factura pdf";
            button7.UseVisualStyleBackColor = false;
            button7.Click += Facturar;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 6);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(460, 42);
            label1.TabIndex = 68;
            label1.Text = "VENTAS PARA REALIZAR FACTURAS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 342);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 101;
            label3.Text = "Volver a ventas";
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(127, 340);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 100;
            button2.Text = "↪️";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Volver;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(290, 48);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 23);
            dateTimePicker1.TabIndex = 102;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 102;
            pictureBox1.TabStop = false;
            // 
            // VentanaFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(734, 391);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(button10);
            Controls.Add(textBox1);
            Controls.Add(TablaFacturas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "VentanaFacturas";
            Load += VentanaFacturas_Load;
            ((System.ComponentModel.ISupportInitialize)TablaFacturas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label2;
        private Button button10;
        private TextBox textBox1;
        private DataGridView TablaFacturas;
        private Button button7;
        private Label label1;
        private Label label3;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
    }
}