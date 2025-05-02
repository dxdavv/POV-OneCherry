namespace POV_OneCherry
{
    partial class VentanaPromociones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPromociones));
            comboBox1 = new ComboBox();
            label2 = new Label();
            button10 = new Button();
            textBox1 = new TextBox();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            TablaPromociones = new DataGridView();
            label8 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)TablaPromociones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ID", "Fecha", "Nombre", "Descuento" });
            comboBox1.Location = new Point(207, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 43;
            comboBox1.SelectedIndexChanged += OnChagedIndex;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 49);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 42;
            label2.Text = "Búsqueda por -›";
            // 
            // button10
            // 
            button10.BackColor = Color.Crimson;
            button10.Font = new Font("Sitka Banner", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(624, 46);
            button10.Name = "button10";
            button10.Size = new Size(102, 35);
            button10.TabIndex = 40;
            button10.Text = "🔎Buscar";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = false;
            button10.Click += Buscar;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(334, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 23);
            textBox1.TabIndex = 41;
            // 
            // button9
            // 
            button9.BackColor = Color.Crimson;
            button9.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(583, 386);
            button9.Name = "button9";
            button9.Size = new Size(161, 43);
            button9.TabIndex = 39;
            button9.Text = "🗑️Eliminar";
            button9.UseVisualStyleBackColor = false;
            button9.Click += Eliminar;
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(319, 386);
            button8.Name = "button8";
            button8.Size = new Size(161, 43);
            button8.TabIndex = 38;
            button8.Text = "🖋️Editar";
            button8.UseVisualStyleBackColor = false;
            button8.Click += Editar;
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(43, 386);
            button7.Name = "button7";
            button7.Size = new Size(161, 43);
            button7.TabIndex = 37;
            button7.Text = "📥Agregar";
            button7.UseVisualStyleBackColor = false;
            button7.Click += Agregar;
            // 
            // TablaPromociones
            // 
            TablaPromociones.AllowUserToAddRows = false;
            TablaPromociones.AllowUserToDeleteRows = false;
            TablaPromociones.BackgroundColor = SystemColors.ButtonHighlight;
            TablaPromociones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaPromociones.Location = new Point(12, 83);
            TablaPromociones.Name = "TablaPromociones";
            TablaPromociones.ReadOnly = true;
            TablaPromociones.Size = new Size(770, 229);
            TablaPromociones.TabIndex = 35;
            TablaPromociones.CellDoubleClick += MandarAEditar;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(498, 320);
            label8.Margin = new Padding(5);
            label8.Name = "label8";
            label8.Size = new Size(93, 28);
            label8.TabIndex = 71;
            label8.Text = "Descuento";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(498, 348);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 23);
            textBox5.TabIndex = 70;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(307, 320);
            label5.Margin = new Padding(5);
            label5.Name = "label5";
            label5.Size = new Size(149, 28);
            label5.TabIndex = 67;
            label5.Text = "Fecha de termino";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(111, 320);
            label7.Margin = new Padding(5);
            label7.Name = "label7";
            label7.Size = new Size(77, 28);
            label7.TabIndex = 66;
            label7.Text = "Nombre";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(111, 348);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 64;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(307, 348);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(173, 23);
            dateTimePicker1.TabIndex = 72;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(334, 54);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(284, 23);
            dateTimePicker2.TabIndex = 73;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 74;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 6);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(386, 42);
            label1.TabIndex = 103;
            label1.Text = "REGISTRO DE PROMOCIONES";
            // 
            // VentanaPromociones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(799, 441);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(button10);
            Controls.Add(textBox1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(TablaPromociones);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "VentanaPromociones";
            Load += VentanaPromociones_Load;
            ((System.ComponentModel.ISupportInitialize)TablaPromociones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label2;
        private Button button10;
        private TextBox textBox1;
        private Button button9;
        private Button button8;
        private Button button7;
        private DataGridView TablaPromociones;
        private Label label8;
        private TextBox textBox5;
        private Label label5;
        private Label label7;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}