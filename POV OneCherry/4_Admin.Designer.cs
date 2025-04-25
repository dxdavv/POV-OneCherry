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
            Proveedores = new DataGridView();
            ID_proveedor = new DataGridViewTextBoxColumn();
            Nombre_proveedor = new DataGridViewTextBoxColumn();
            Email_proveedor = new DataGridViewTextBoxColumn();
            Telefono_proveedor = new DataGridViewTextBoxColumn();
            Dirección_proveedor = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button6 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Proveedores).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
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
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.LavenderBlush;
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
            splitContainer1.Panel2.Controls.Add(Proveedores);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(button6);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1122, 604);
            splitContainer1.SplitterDistance = 152;
            splitContainer1.SplitterWidth = 5;
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
            button11.Location = new Point(2, 300);
            button11.Margin = new Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new Size(149, 40);
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
            button5.Location = new Point(1, 260);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(149, 40);
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
            button4.Location = new Point(1, 220);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(149, 40);
            button4.TabIndex = 6;
            button4.Text = "\U0001f6d2Productos";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Productos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 7);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1, 573);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(149, 40);
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
            Productos.Location = new Point(1, 180);
            Productos.Margin = new Padding(3, 4, 3, 4);
            Productos.Name = "Productos";
            Productos.Size = new Size(149, 40);
            Productos.TabIndex = 3;
            Productos.Text = "\U0001f947Admins";
            Productos.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(1, 140);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(149, 40);
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
            button2.Location = new Point(1, 100);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(149, 40);
            button2.TabIndex = 1;
            button2.Text = "👥Clientes";
            button2.UseVisualStyleBackColor = false;
            // 
            // ButtonProveedor
            // 
            ButtonProveedor.BackColor = Color.Crimson;
            ButtonProveedor.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonProveedor.ForeColor = SystemColors.ControlLightLight;
            ButtonProveedor.Location = new Point(1, 60);
            ButtonProveedor.Margin = new Padding(3, 4, 3, 4);
            ButtonProveedor.Name = "ButtonProveedor";
            ButtonProveedor.Size = new Size(149, 40);
            ButtonProveedor.TabIndex = 0;
            ButtonProveedor.Text = "🚚Proveedores";
            ButtonProveedor.UseVisualStyleBackColor = false;
            ButtonProveedor.Click += ButtonProveedor_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Crimson;
            button12.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.ForeColor = SystemColors.ControlLightLight;
<<<<<<< Updated upstream
            button12.Location = new Point(612, 406);
            button12.Name = "button12";
            button12.Size = new Size(193, 43);
=======
            button12.Location = new Point(699, 541);
            button12.Margin = new Padding(3, 4, 3, 4);
            button12.Name = "button12";
            button12.Size = new Size(221, 57);
>>>>>>> Stashed changes
            button12.TabIndex = 64;
            button12.Text = "Compras a proveedor";
            button12.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(458, 453);
            label8.Margin = new Padding(6, 7, 6, 7);
            label8.Name = "label8";
            label8.Size = new Size(100, 35);
            label8.TabIndex = 63;
            label8.Text = "Telefono";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(458, 491);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(196, 27);
            textBox5.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(672, 453);
            label3.Margin = new Padding(6, 7, 6, 7);
            label3.Name = "label3";
            label3.Size = new Size(111, 35);
            label3.TabIndex = 60;
            label3.Text = "Dirección";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(672, 491);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(247, 27);
            textBox4.TabIndex = 58;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(240, 453);
            label5.Margin = new Padding(6, 7, 6, 7);
            label5.Name = "label5";
            label5.Size = new Size(73, 35);
            label5.TabIndex = 57;
            label5.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 453);
            label7.Margin = new Padding(6, 7, 6, 7);
            label7.Name = "label7";
            label7.Size = new Size(96, 35);
            label7.TabIndex = 56;
            label7.Text = "Nombre";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(240, 491);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(196, 27);
            textBox3.TabIndex = 55;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 491);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 27);
            textBox2.TabIndex = 54;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ID", "Nombre", "Teléfono", "Email" });
            comboBox1.Location = new Point(175, 67);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 30;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 60);
            label2.Margin = new Padding(6, 7, 6, 7);
            label2.Name = "label2";
            label2.Size = new Size(176, 35);
            label2.TabIndex = 29;
            label2.Text = "Búsqueda por -›";
            // 
            // button10
            // 
            button10.BackColor = Color.Crimson;
            button10.Font = new Font("Sitka Banner", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(651, 56);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(117, 47);
            button10.TabIndex = 27;
            button10.Text = "🔎Buscar";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(320, 67);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 27);
            textBox1.TabIndex = 28;
            // 
            // button9
            // 
            button9.BackColor = Color.Crimson;
            button9.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(473, 541);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(171, 57);
            button9.TabIndex = 25;
            button9.Text = "🗑️Eliminar";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(265, 541);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(171, 57);
            button8.TabIndex = 24;
            button8.Text = "🖋️Editar";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(63, 541);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(171, 57);
            button7.TabIndex = 21;
            button7.Text = "📥Agregar";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Proveedores
            // 
            Proveedores.AllowUserToAddRows = false;
            Proveedores.AllowUserToDeleteRows = false;
            Proveedores.BackgroundColor = SystemColors.ButtonHighlight;
            Proveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Proveedores.Columns.AddRange(new DataGridViewColumn[] { ID_proveedor, Nombre_proveedor, Email_proveedor, Telefono_proveedor, Dirección_proveedor });
            Proveedores.Location = new Point(63, 105);
            Proveedores.Margin = new Padding(3, 4, 3, 4);
            Proveedores.Name = "Proveedores";
            Proveedores.ReadOnly = true;
            Proveedores.RowHeadersWidth = 51;
            Proveedores.Size = new Size(857, 337);
            Proveedores.TabIndex = 4;
            // 
            // ID_proveedor
            // 
            ID_proveedor.HeaderText = "ID";
            ID_proveedor.MinimumWidth = 6;
            ID_proveedor.Name = "ID_proveedor";
            ID_proveedor.ReadOnly = true;
            ID_proveedor.Width = 150;
            // 
            // Nombre_proveedor
            // 
            Nombre_proveedor.HeaderText = "Nombre";
            Nombre_proveedor.MinimumWidth = 6;
            Nombre_proveedor.Name = "Nombre_proveedor";
            Nombre_proveedor.ReadOnly = true;
            Nombre_proveedor.Width = 150;
            // 
            // Email_proveedor
            // 
            Email_proveedor.HeaderText = "Email";
            Email_proveedor.MinimumWidth = 6;
            Email_proveedor.Name = "Email_proveedor";
            Email_proveedor.ReadOnly = true;
            Email_proveedor.Width = 150;
            // 
            // Telefono_proveedor
            // 
            Telefono_proveedor.HeaderText = "Teléfono";
            Telefono_proveedor.MinimumWidth = 6;
            Telefono_proveedor.Name = "Telefono_proveedor";
            Telefono_proveedor.ReadOnly = true;
            Telefono_proveedor.Width = 150;
            // 
            // Dirección_proveedor
            // 
            Dirección_proveedor.HeaderText = "Dirección";
            Dirección_proveedor.MinimumWidth = 6;
            Dirección_proveedor.Name = "Dirección_proveedor";
            Dirección_proveedor.ReadOnly = true;
            Dirección_proveedor.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 8);
            label1.Margin = new Padding(6, 7, 6, 7);
            label1.Name = "label1";
            label1.Size = new Size(262, 53);
            label1.TabIndex = 3;
            label1.Text = "PROVEEDORES";
            label1.Click += label1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.OliveDrab;
            button6.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(918, 1);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(46, 40);
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
            label4.Location = new Point(753, 1);
            label4.Margin = new Padding(6, 7, 6, 7);
            label4.Name = "label4";
            label4.Size = new Size(184, 35);
            label4.TabIndex = 1;
            label4.Text = "Nombre Apellido";
            label4.Click += label4_Click;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(1122, 604);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1140, 651);
            MinimumSize = new Size(1140, 651);
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
            ((System.ComponentModel.ISupportInitialize)Proveedores).EndInit();
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
        private DataGridView Proveedores;
        private Button button7;
        private Button button9;
        private Button button8;
        private Label label2;
        private Button button10;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button11;
        private DataGridViewTextBoxColumn ID_proveedor;
        private DataGridViewTextBoxColumn Nombre_proveedor;
        private DataGridViewTextBoxColumn Email_proveedor;
        private DataGridViewTextBoxColumn Telefono_proveedor;
        private DataGridViewTextBoxColumn Dirección_proveedor;
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
    }
}