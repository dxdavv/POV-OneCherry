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
            comboBox1 = new ComboBox();
            label2 = new Label();
            button10 = new Button();
            textBox1 = new TextBox();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ID_promocion = new DataGridViewTextBoxColumn();
            Nombre_promocion = new DataGridViewTextBoxColumn();
            Fecha_promocion = new DataGridViewTextBoxColumn();
            Descuento_promocion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ID", "Fecha", "Nombre" });
            comboBox1.Location = new Point(183, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 48);
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
            button10.Location = new Point(600, 45);
            button10.Name = "button10";
            button10.Size = new Size(102, 35);
            button10.TabIndex = 40;
            button10.Text = "🔎Buscar";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(310, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 23);
            textBox1.TabIndex = 41;
            // 
            // button9
            // 
            button9.BackColor = Color.Crimson;
            button9.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(582, 342);
            button9.Name = "button9";
            button9.Size = new Size(161, 43);
            button9.TabIndex = 39;
            button9.Text = "🗑️Eliminar";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(323, 342);
            button8.Name = "button8";
            button8.Size = new Size(161, 43);
            button8.TabIndex = 38;
            button8.Text = "🖋️Editar";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(48, 342);
            button7.Name = "button7";
            button7.Size = new Size(161, 43);
            button7.TabIndex = 37;
            button7.Text = "📥Agregar";
            button7.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(-2, -1);
            label1.Name = "label1";
            label1.Size = new Size(145, 35);
            label1.TabIndex = 36;
            label1.Text = "Promociones";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_promocion, Nombre_promocion, Fecha_promocion, Descuento_promocion });
            dataGridView1.Location = new Point(11, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(770, 250);
            dataGridView1.TabIndex = 35;
            // 
            // ID_promocion
            // 
            ID_promocion.HeaderText = "ID";
            ID_promocion.Name = "ID_promocion";
            ID_promocion.ReadOnly = true;
            ID_promocion.Width = 50;
            // 
            // Nombre_promocion
            // 
            Nombre_promocion.HeaderText = "Nombre";
            Nombre_promocion.Name = "Nombre_promocion";
            Nombre_promocion.ReadOnly = true;
            Nombre_promocion.Width = 240;
            // 
            // Fecha_promocion
            // 
            Fecha_promocion.HeaderText = "Fecha";
            Fecha_promocion.Name = "Fecha_promocion";
            Fecha_promocion.ReadOnly = true;
            Fecha_promocion.Width = 240;
            // 
            // Descuento_promocion
            // 
            Descuento_promocion.HeaderText = "Descuento";
            Descuento_promocion.Name = "Descuento_promocion";
            Descuento_promocion.ReadOnly = true;
            Descuento_promocion.Width = 240;
            // 
            // VentanaPromociones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(799, 411);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(button10);
            Controls.Add(textBox1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "VentanaPromociones";
            Text = "REGISTRO DE PROMOCIONES";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID_promocion;
        private DataGridViewTextBoxColumn Nombre_promocion;
        private DataGridViewTextBoxColumn Fecha_promocion;
        private DataGridViewTextBoxColumn Descuento_promocion;
    }
}