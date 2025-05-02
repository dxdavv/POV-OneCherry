namespace POV_OneCherry
{
    partial class ListaComprasProv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaComprasProv));
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button10 = new Button();
            textBox1 = new TextBox();
            TablaListaCompras = new DataGridView();
            button12 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TablaListaCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 4);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(479, 42);
            label1.TabIndex = 68;
            label1.Text = "LISTA DE COMPRAS A PROVEEDORES";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(137, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 73;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 47);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 72;
            label2.Text = "Buscar por -›";
            // 
            // button10
            // 
            button10.BackColor = Color.Crimson;
            button10.Font = new Font("Sitka Banner", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(554, 44);
            button10.Name = "button10";
            button10.Size = new Size(102, 35);
            button10.TabIndex = 70;
            button10.Text = "🔎Buscar";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = false;
            button10.Click += Buscar;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(264, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 23);
            textBox1.TabIndex = 71;
            // 
            // TablaListaCompras
            // 
            TablaListaCompras.AllowUserToAddRows = false;
            TablaListaCompras.AllowUserToDeleteRows = false;
            TablaListaCompras.BackgroundColor = SystemColors.ButtonHighlight;
            TablaListaCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaListaCompras.Location = new Point(12, 85);
            TablaListaCompras.Name = "TablaListaCompras";
            TablaListaCompras.ReadOnly = true;
            TablaListaCompras.Size = new Size(736, 253);
            TablaListaCompras.TabIndex = 69;
            // 
            // button12
            // 
            button12.BackColor = Color.OliveDrab;
            button12.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.ForeColor = SystemColors.ControlLightLight;
            button12.Location = new Point(12, 344);
            button12.Name = "button12";
            button12.Size = new Size(160, 43);
            button12.TabIndex = 86;
            button12.Text = "⏬Descarga excel";
            button12.UseVisualStyleBackColor = false;
            button12.Click += ToExcel;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 87;
            pictureBox1.TabStop = false;
            // 
            // ListaComprasProv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(784, 391);
            Controls.Add(pictureBox1);
            Controls.Add(button12);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(button10);
            Controls.Add(textBox1);
            Controls.Add(TablaListaCompras);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ListaComprasProv";
            Load += ListaComprasProv_Load;
            ((System.ComponentModel.ISupportInitialize)TablaListaCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Button button10;
        private TextBox textBox1;
        private DataGridView TablaListaCompras;
        private Button button12;
        private PictureBox pictureBox1;
    }
}