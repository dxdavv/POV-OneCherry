namespace POV_OneCherry
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            splitContainer1 = new SplitContainer();
            button11 = new Button();
            button5 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            Productos = new Button();
            button3 = new Button();
            button2 = new Button();
            ButtonProveedor = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button10 = new Button();
            textBox1 = new TextBox();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button6 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.LavenderBlush;
            splitContainer1.Panel1.Controls.Add(button11);
            splitContainer1.Panel1.Controls.Add(button5);
            splitContainer1.Panel1.Controls.Add(button4);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(Productos);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(ButtonProveedor);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.LavenderBlush;
            splitContainer1.Panel2.Controls.Add(comboBox1);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(button10);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(button9);
            splitContainer1.Panel2.Controls.Add(button8);
            splitContainer1.Panel2.Controls.Add(button7);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(button6);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(984, 461);
            splitContainer1.SplitterDistance = 134;
            splitContainer1.TabIndex = 0;
            // 
            // button11
            // 
            button11.BackColor = Color.Crimson;
            button11.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.ForeColor = SystemColors.ControlLightLight;
            button11.Location = new Point(2, 225);
            button11.Name = "button11";
            button11.Size = new Size(130, 30);
            button11.TabIndex = 8;
            button11.Text = "🎁Promociones";
            button11.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(1, 195);
            button5.Name = "button5";
            button5.Size = new Size(130, 30);
            button5.TabIndex = 7;
            button5.Text = "🔑Usuarios";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(1, 165);
            button4.Name = "button4";
            button4.Size = new Size(130, 30);
            button4.TabIndex = 6;
            button4.Text = "💰Ventas";
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1, 430);
            button1.Name = "button1";
            button1.Size = new Size(130, 30);
            button1.TabIndex = 4;
            button1.Text = "📌Soporte";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Productos
            // 
            Productos.BackColor = Color.Crimson;
            Productos.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Productos.ForeColor = SystemColors.ControlLightLight;
            Productos.Location = new Point(1, 135);
            Productos.Name = "Productos";
            Productos.Size = new Size(130, 30);
            Productos.TabIndex = 3;
            Productos.Text = "\U0001f6d2Productos";
            Productos.UseVisualStyleBackColor = false;
            Productos.Click += Productos_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(1, 105);
            button3.Name = "button3";
            button3.Size = new Size(130, 30);
            button3.TabIndex = 2;
            button3.Text = "👤Empleados";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1, 75);
            button2.Name = "button2";
            button2.Size = new Size(130, 30);
            button2.TabIndex = 1;
            button2.Text = "👥Clientes";
            button2.UseVisualStyleBackColor = false;
            // 
            // ButtonProveedor
            // 
            ButtonProveedor.BackColor = Color.Crimson;
            ButtonProveedor.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonProveedor.ForeColor = SystemColors.ControlLightLight;
            ButtonProveedor.Location = new Point(1, 45);
            ButtonProveedor.Name = "ButtonProveedor";
            ButtonProveedor.Size = new Size(130, 30);
            ButtonProveedor.TabIndex = 0;
            ButtonProveedor.Text = "🚚Proveedores";
            ButtonProveedor.UseVisualStyleBackColor = false;
            ButtonProveedor.Click += ButtonProveedor_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ID", "Nombre", "Teléfono", "Email" });
            comboBox1.Location = new Point(157, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 30;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 51);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 29;
            label2.Text = "Búsqueda por -›";
            // 
            // button10
            // 
            button10.BackColor = Color.Crimson;
            button10.Font = new Font("Sitka Banner", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(574, 48);
            button10.Name = "button10";
            button10.Size = new Size(102, 35);
            button10.TabIndex = 27;
            button10.Text = "🔎Buscar";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(284, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 23);
            textBox1.TabIndex = 28;
            // 
            // button9
            // 
            button9.BackColor = Color.Crimson;
            button9.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(625, 406);
            button9.Name = "button9";
            button9.Size = new Size(161, 43);
            button9.TabIndex = 25;
            button9.Text = "🗑️Eliminar";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(366, 406);
            button8.Name = "button8";
            button8.Size = new Size(161, 43);
            button8.TabIndex = 24;
            button8.Text = "🖋️Editar";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(91, 406);
            button7.Name = "button7";
            button7.Size = new Size(161, 43);
            button7.TabIndex = 21;
            button7.Text = "📥Agregar";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(750, 301);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 6);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(204, 42);
            label1.TabIndex = 3;
            label1.Text = "PROVEEDORES";
            label1.Click += label1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.OliveDrab;
            button6.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(803, 1);
            button6.Name = "button6";
            button6.Size = new Size(40, 30);
            button6.TabIndex = 2;
            button6.Text = "➡️";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(659, 1);
            label4.Margin = new Padding(5);
            label4.Name = "label4";
            label4.Size = new Size(146, 28);
            label4.TabIndex = 1;
            label4.Text = "Nombre Apellido";
            label4.Click += label4_Click;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(984, 461);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1000, 500);
            MinimumSize = new Size(1000, 500);
            Name = "Administrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMIN";
            Load += Form2_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button ButtonProveedor;
        private Button button3;
        private Button Productos;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Label label4;
        private Button button6;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button7;
        private Button button9;
        private Button button8;
        private Label label2;
        private Button button10;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button11;
    }
}