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
            button13 = new Button();
            button11 = new Button();
            button5 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            Productos = new Button();
            button3 = new Button();
            button2 = new Button();
            ButtonProveedor = new Button();
            label6 = new Label();
            comboBox2 = new ComboBox();
            button12 = new Button();
            label8 = new Label();
            textBox5 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
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
            splitContainer1.Panel1.Controls.Add(button13);
            splitContainer1.Panel1.Controls.Add(button11);
            splitContainer1.Panel1.Controls.Add(button5);
            splitContainer1.Panel1.Controls.Add(button4);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(Productos);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(ButtonProveedor);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.LavenderBlush;
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(comboBox2);
            splitContainer1.Panel2.Controls.Add(button12);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(textBox5);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(textBox4);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(textBox3);
            splitContainer1.Panel2.Controls.Add(textBox2);
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
            splitContainer1.Size = new Size(984, 461);
            splitContainer1.SplitterDistance = 134;
            splitContainer1.TabIndex = 0;
            // 
            // button13
            // 
            button13.BackColor = Color.Crimson;
            button13.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.ForeColor = SystemColors.ControlLightLight;
            button13.Location = new Point(3, 255);
            button13.Name = "button13";
            button13.Size = new Size(130, 30);
            button13.TabIndex = 9;
            button13.Text = "🎁Promociones";
            button13.UseVisualStyleBackColor = false;
            button13.Click += botonPromociones;
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
            button11.Text = "🔑Usuarios";
            button11.UseVisualStyleBackColor = false;
            button11.Click += botonUsuarios;
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
            button5.Text = "💰Ventas";
            button5.UseVisualStyleBackColor = false;
            button5.Click += botonVenta;
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
            button4.Text = "\U0001f6d2Productos";
            button4.UseVisualStyleBackColor = false;
            button4.Click += botonProductos;
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
            button1.Click += botonSoporte;
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
            Productos.Text = "\U0001f947Admins";
            Productos.UseVisualStyleBackColor = false;
            Productos.Click += botonAdministradores;
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
            button3.Click += botonEmpleados;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1, 45);
            button2.Name = "button2";
            button2.Size = new Size(130, 30);
            button2.TabIndex = 1;
            button2.Text = "👥Clientes";
            button2.UseVisualStyleBackColor = false;
            button2.Click += botonClientes;
            // 
            // ButtonProveedor
            // 
            ButtonProveedor.BackColor = Color.Crimson;
            ButtonProveedor.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonProveedor.ForeColor = SystemColors.ControlLightLight;
            ButtonProveedor.Location = new Point(1, 75);
            ButtonProveedor.Name = "ButtonProveedor";
            ButtonProveedor.Size = new Size(130, 30);
            ButtonProveedor.TabIndex = 0;
            ButtonProveedor.Text = "🚚Proveedores";
            ButtonProveedor.UseVisualStyleBackColor = false;
            ButtonProveedor.Click += botonProveedores;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(684, 340);
            label6.Margin = new Padding(5);
            label6.Name = "label6";
            label6.Size = new Size(72, 28);
            label6.TabIndex = 66;
            label6.Text = "Cambio";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(684, 368);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 65;
            // 
            // button12
            // 
            button12.BackColor = Color.Crimson;
            button12.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.ForeColor = SystemColors.ControlLightLight;
            button12.Location = new Point(612, 406);
            button12.Name = "button12";
            button12.Size = new Size(193, 43);
            button12.TabIndex = 64;
            button12.Text = "Compras a proveedor";
            button12.UseVisualStyleBackColor = false;
            button12.Click += botonComprasProveedor;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(357, 340);
            label8.Margin = new Padding(5);
            label8.Name = "label8";
            label8.Size = new Size(79, 28);
            label8.TabIndex = 63;
            label8.Text = "Telefono";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(357, 368);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(123, 23);
            textBox5.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(496, 340);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 60;
            label3.Text = "Dirección";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(496, 368);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(176, 23);
            textBox4.TabIndex = 58;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(169, 340);
            label5.Margin = new Padding(5);
            label5.Name = "label5";
            label5.Size = new Size(58, 28);
            label5.TabIndex = 57;
            label5.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 340);
            label7.Margin = new Padding(5);
            label7.Name = "label7";
            label7.Size = new Size(77, 28);
            label7.TabIndex = 56;
            label7.Text = "Nombre";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(169, 368);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 368);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 23);
            textBox2.TabIndex = 54;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(153, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 45);
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
            button10.Location = new Point(570, 42);
            button10.Name = "button10";
            button10.Size = new Size(102, 35);
            button10.TabIndex = 27;
            button10.Text = "🔎Buscar";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = false;
            button10.Click += Buscar;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(280, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 23);
            textBox1.TabIndex = 28;
            // 
            // button9
            // 
            button9.BackColor = Color.Crimson;
            button9.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(414, 406);
            button9.Name = "button9";
            button9.Size = new Size(150, 43);
            button9.TabIndex = 25;
            button9.Text = "🗑️Eliminar";
            button9.UseVisualStyleBackColor = false;
            button9.Click += Eliminar;
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(232, 406);
            button8.Name = "button8";
            button8.Size = new Size(150, 43);
            button8.TabIndex = 24;
            button8.Text = "🖋️Editar";
            button8.UseVisualStyleBackColor = false;
            button8.Click += Editar;
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(55, 406);
            button7.Name = "button7";
            button7.Size = new Size(150, 43);
            button7.TabIndex = 21;
            button7.Text = "📥Agregar";
            button7.UseVisualStyleBackColor = false;
            button7.Click += Agregar;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(750, 253);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellDoubleClick += MandarAEditar;
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
            Load += Administrador_Load;
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
        private Label label8;
        private TextBox textBox5;
        private Label label3;
        private TextBox textBox4;
        private Label label5;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button12;
        private Button button13;
        private ComboBox comboBox2;
        private Label label6;
    }
}