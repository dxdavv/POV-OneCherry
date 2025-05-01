namespace POV_OneCherry
{
    partial class VentanaCategoría
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaCategoría));
            label7 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button10 = new Button();
            textBox1 = new TextBox();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            TablaCategorias = new DataGridView();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)TablaCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(311, 273);
            label7.Margin = new Padding(5);
            label7.Name = "label7";
            label7.Size = new Size(197, 28);
            label7.TabIndex = 104;
            label7.Text = "Nombre de la categoría";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(267, 309);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 23);
            textBox2.TabIndex = 95;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ID", "Nombre" });
            comboBox1.Location = new Point(184, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 94;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 50);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 93;
            label2.Text = "Búsqueda por -›";
            // 
            // button10
            // 
            button10.BackColor = Color.Crimson;
            button10.Font = new Font("Sitka Banner", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(601, 47);
            button10.Name = "button10";
            button10.Size = new Size(102, 35);
            button10.TabIndex = 91;
            button10.Text = "🔎Buscar";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = false;
            button10.Click += Buscar;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(311, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 23);
            textBox1.TabIndex = 92;
            // 
            // button9
            // 
            button9.BackColor = Color.Crimson;
            button9.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(579, 343);
            button9.Name = "button9";
            button9.Size = new Size(161, 43);
            button9.TabIndex = 90;
            button9.Text = "🗑️Eliminar";
            button9.UseVisualStyleBackColor = false;
            button9.Click += Eliminar;
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(320, 343);
            button8.Name = "button8";
            button8.Size = new Size(161, 43);
            button8.TabIndex = 89;
            button8.Text = "🖋️Editar";
            button8.UseVisualStyleBackColor = false;
            button8.Click += Editar;
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(45, 343);
            button7.Name = "button7";
            button7.Size = new Size(161, 43);
            button7.TabIndex = 88;
            button7.Text = "📥Agregar";
            button7.UseVisualStyleBackColor = false;
            button7.Click += Agregar;
            // 
            // TablaCategorias
            // 
            TablaCategorias.AllowUserToAddRows = false;
            TablaCategorias.AllowUserToDeleteRows = false;
            TablaCategorias.BackgroundColor = SystemColors.ButtonHighlight;
            TablaCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaCategorias.Location = new Point(12, 88);
            TablaCategorias.Name = "TablaCategorias";
            TablaCategorias.ReadOnly = true;
            TablaCategorias.Size = new Size(775, 177);
            TablaCategorias.TabIndex = 86;
            TablaCategorias.CellDoubleClick += MandarAEditar;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 105;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Heading", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(98, 6);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(386, 42);
            label3.TabIndex = 106;
            label3.Text = "CATEGORIAS DE PRODUCTOS";
            // 
            // VentanaCategoría
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(804, 391);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(button10);
            Controls.Add(textBox1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(TablaCategorias);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "VentanaCategoría";
            Load += VentanaCategoría_Load;
            ((System.ComponentModel.ISupportInitialize)TablaCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Button button10;
        private TextBox textBox1;
        private Button button9;
        private Button button8;
        private Button button7;
        private DataGridView TablaCategorias;
        private PictureBox pictureBox1;
        private Label label3;
    }
}