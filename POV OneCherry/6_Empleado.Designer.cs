namespace POV_OneCherry
{
    partial class Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            splitContainer1 = new SplitContainer();
            button5 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button6 = new Button();
            label4 = new Label();
            splitContainer2 = new SplitContainer();
            button8 = new Button();
            label8 = new Label();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            label7 = new Label();
            label6 = new Label();
            button1 = new Button();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            TablaClientes = new DataGridView();
            button7 = new Button();
            button10 = new Button();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label5 = new Label();
            TablaProducto = new DataGridView();
            button4 = new Button();
            button9 = new Button();
            button3 = new Button();
            textBox9 = new TextBox();
            label13 = new Label();
            textBox6 = new TextBox();
            label12 = new Label();
            textBox5 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            TablaVenta = new DataGridView();
            nombreProducto = new DataGridViewTextBoxColumn();
            cantidadProducto = new DataGridViewTextBoxColumn();
            precioUnitario = new DataGridViewTextBoxColumn();
            subTotal = new DataGridViewTextBoxColumn();
            label2 = new Label();
            comboBox4 = new ComboBox();
            label21 = new Label();
            button11 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TablaClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TablaProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TablaVenta).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.LavenderBlush;
            splitContainer1.Panel1.Controls.Add(button5);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(button6);
            splitContainer1.Panel1.Controls.Add(label4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(984, 661);
            splitContainer1.SplitterDistance = 47;
            splitContainer1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.OliveDrab;
            button5.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(96, 10);
            button5.Name = "button5";
            button5.Size = new Size(70, 30);
            button5.TabIndex = 50;
            button5.Text = "Manual";
            button5.UseVisualStyleBackColor = false;
            button5.Click += ManualEmpleado;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Subheading", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(382, 1);
            label3.Name = "label3";
            label3.Size = new Size(289, 47);
            label3.TabIndex = 49;
            label3.Text = "PUNTO DE VENTA";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.OliveDrab;
            button6.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(938, 6);
            button6.Name = "button6";
            button6.Size = new Size(40, 30);
            button6.TabIndex = 4;
            button6.Text = "➡️";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(794, 6);
            label4.Margin = new Padding(5);
            label4.Name = "label4";
            label4.Size = new Size(146, 28);
            label4.TabIndex = 3;
            label4.Text = "Nombre Apellido";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.LavenderBlush;
            splitContainer2.Panel1.Controls.Add(button8);
            splitContainer2.Panel1.Controls.Add(label8);
            splitContainer2.Panel1.Controls.Add(numericUpDown1);
            splitContainer2.Panel1.Controls.Add(button2);
            splitContainer2.Panel1.Controls.Add(label7);
            splitContainer2.Panel1.Controls.Add(label6);
            splitContainer2.Panel1.Controls.Add(button1);
            splitContainer2.Panel1.Controls.Add(comboBox2);
            splitContainer2.Panel1.Controls.Add(textBox1);
            splitContainer2.Panel1.Controls.Add(label1);
            splitContainer2.Panel1.Controls.Add(TablaClientes);
            splitContainer2.Panel1.Controls.Add(button7);
            splitContainer2.Panel1.Controls.Add(button10);
            splitContainer2.Panel1.Controls.Add(comboBox1);
            splitContainer2.Panel1.Controls.Add(textBox2);
            splitContainer2.Panel1.Controls.Add(label5);
            splitContainer2.Panel1.Controls.Add(TablaProducto);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.LavenderBlush;
            splitContainer2.Panel2.Controls.Add(button4);
            splitContainer2.Panel2.Controls.Add(button9);
            splitContainer2.Panel2.Controls.Add(button3);
            splitContainer2.Panel2.Controls.Add(textBox9);
            splitContainer2.Panel2.Controls.Add(label13);
            splitContainer2.Panel2.Controls.Add(textBox6);
            splitContainer2.Panel2.Controls.Add(label12);
            splitContainer2.Panel2.Controls.Add(textBox5);
            splitContainer2.Panel2.Controls.Add(label11);
            splitContainer2.Panel2.Controls.Add(label10);
            splitContainer2.Panel2.Controls.Add(TablaVenta);
            splitContainer2.Panel2.Controls.Add(label2);
            splitContainer2.Panel2.Controls.Add(comboBox4);
            splitContainer2.Panel2.Controls.Add(label21);
            splitContainer2.Size = new Size(984, 610);
            splitContainer2.SplitterDistance = 513;
            splitContainer2.TabIndex = 0;
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(430, 331);
            button8.Name = "button8";
            button8.Size = new Size(80, 35);
            button8.TabIndex = 48;
            button8.Text = "🔎Buscar";
            button8.TextAlign = ContentAlignment.TopCenter;
            button8.UseVisualStyleBackColor = false;
            button8.Click += BuscarClientes;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 268);
            label8.Margin = new Padding(5);
            label8.Name = "label8";
            label8.Size = new Size(82, 28);
            label8.TabIndex = 47;
            label8.Text = "Cantidad";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(96, 273);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 17;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(307, 563);
            button2.Name = "button2";
            button2.Size = new Size(192, 39);
            button2.TabIndex = 46;
            button2.Text = "📂Elegir cliente";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AgregarClienteVenta;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sitka Heading", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(212, 0);
            label7.Name = "label7";
            label7.Size = new Size(106, 35);
            label7.TabIndex = 45;
            label7.Text = "Producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Sitka Heading", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(212, 299);
            label6.Name = "label6";
            label6.Size = new Size(85, 35);
            label6.TabIndex = 44;
            label6.Text = "Cliente";
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(12, 563);
            button1.Name = "button1";
            button1.Size = new Size(192, 39);
            button1.TabIndex = 40;
            button1.Text = "📥Agregar nuevo cliente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += botonAgregarCliente;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ID", "Nombre", "Apellido", "Email", "Teléfono" });
            comboBox2.Location = new Point(143, 337);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(112, 23);
            comboBox2.TabIndex = 43;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 337);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 23);
            textBox1.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 333);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 42;
            label1.Text = "Búsqueda por -›";
            // 
            // TablaClientes
            // 
            TablaClientes.AllowUserToOrderColumns = true;
            TablaClientes.BackgroundColor = SystemColors.ButtonHighlight;
            TablaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaClientes.Location = new Point(12, 369);
            TablaClientes.Name = "TablaClientes";
            TablaClientes.Size = new Size(487, 188);
            TablaClientes.TabIndex = 39;
            TablaClientes.CellDoubleClick += MandarAAgregarClientes;
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(307, 266);
            button7.Name = "button7";
            button7.Size = new Size(192, 39);
            button7.TabIndex = 22;
            button7.Text = "📥Agregar a la venta";
            button7.UseVisualStyleBackColor = false;
            button7.Click += AgregarProductoVenta;
            // 
            // button10
            // 
            button10.BackColor = Color.Crimson;
            button10.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(432, 36);
            button10.Name = "button10";
            button10.Size = new Size(80, 35);
            button10.TabIndex = 35;
            button10.Text = "🔎Buscar";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = false;
            button10.Click += BuscarProductos;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ID", "Nombre", "Precio", "Stock", "Categoría" });
            comboBox1.Location = new Point(143, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(112, 23);
            comboBox1.TabIndex = 38;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 23);
            textBox2.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 36);
            label5.Margin = new Padding(5);
            label5.Name = "label5";
            label5.Size = new Size(140, 28);
            label5.TabIndex = 37;
            label5.Text = "Búsqueda por -›";
            // 
            // TablaProducto
            // 
            TablaProducto.AllowUserToOrderColumns = true;
            TablaProducto.BackgroundColor = SystemColors.ButtonHighlight;
            TablaProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaProducto.Location = new Point(12, 72);
            TablaProducto.Name = "TablaProducto";
            TablaProducto.Size = new Size(487, 188);
            TablaProducto.TabIndex = 18;
            TablaProducto.CellDoubleClick += MandarAAgregarProductos;
            // 
            // button4
            // 
            button4.BackColor = Color.OliveDrab;
            button4.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(13, 559);
            button4.Name = "button4";
            button4.Size = new Size(192, 39);
            button4.TabIndex = 57;
            button4.Text = "❎Cancelar venta";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Cancelar;
            // 
            // button9
            // 
            button9.BackColor = Color.Crimson;
            button9.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(415, 464);
            button9.Name = "button9";
            button9.Size = new Size(30, 30);
            button9.TabIndex = 49;
            button9.Text = "↩️";
            button9.TextAlign = ContentAlignment.TopCenter;
            button9.UseVisualStyleBackColor = false;
            button9.Click += Cambio;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(263, 559);
            button3.Name = "button3";
            button3.Size = new Size(192, 39);
            button3.TabIndex = 49;
            button3.Text = "✅Finalizar venta";
            button3.UseVisualStyleBackColor = false;
            button3.Click += FinalizarVenta;
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Location = new Point(134, 507);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(273, 23);
            textBox9.TabIndex = 55;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(13, 502);
            label13.Margin = new Padding(5);
            label13.Name = "label13";
            label13.Size = new Size(78, 28);
            label13.TabIndex = 56;
            label13.Text = "Cambio:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(134, 464);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(273, 23);
            textBox6.TabIndex = 53;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(13, 459);
            label12.Margin = new Padding(5);
            label12.Name = "label12";
            label12.Size = new Size(87, 28);
            label12.TabIndex = 54;
            label12.Text = "Paga con:";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(134, 428);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(273, 23);
            textBox5.TabIndex = 51;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(13, 421);
            label11.Margin = new Padding(5);
            label11.Name = "label11";
            label11.Size = new Size(121, 28);
            label11.TabIndex = 52;
            label11.Text = "Total a pagar:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(13, 385);
            label10.Margin = new Padding(5);
            label10.Name = "label10";
            label10.Size = new Size(102, 28);
            label10.TabIndex = 50;
            label10.Text = "Promoción:";
            // 
            // TablaVenta
            // 
            TablaVenta.AllowUserToAddRows = false;
            TablaVenta.AllowUserToDeleteRows = false;
            TablaVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TablaVenta.BackgroundColor = SystemColors.ButtonHighlight;
            TablaVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaVenta.Columns.AddRange(new DataGridViewColumn[] { nombreProducto, cantidadProducto, precioUnitario, subTotal });
            TablaVenta.Location = new Point(13, 40);
            TablaVenta.Name = "TablaVenta";
            TablaVenta.ReadOnly = true;
            TablaVenta.Size = new Size(432, 326);
            TablaVenta.TabIndex = 16;
            TablaVenta.CellDoubleClick += MandarAEliminarProductos;
            // 
            // nombreProducto
            // 
            nombreProducto.HeaderText = "Producto";
            nombreProducto.Name = "nombreProducto";
            nombreProducto.ReadOnly = true;
            // 
            // cantidadProducto
            // 
            cantidadProducto.HeaderText = "Cantidad";
            cantidadProducto.Name = "cantidadProducto";
            cantidadProducto.ReadOnly = true;
            // 
            // precioUnitario
            // 
            precioUnitario.HeaderText = "Precio Unitario";
            precioUnitario.Name = "precioUnitario";
            precioUnitario.ReadOnly = true;
            // 
            // subTotal
            // 
            subTotal.HeaderText = "Subtotal";
            subTotal.Name = "subTotal";
            subTotal.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 9);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 14;
            label2.Text = "Venta, cliente:";
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(134, 390);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(273, 23);
            comboBox4.TabIndex = 49;
            comboBox4.SelectedIndexChanged += onPromoSelected;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(134, 9);
            label21.Name = "label21";
            label21.Size = new Size(146, 28);
            label21.TabIndex = 15;
            label21.Text = "Nombre Apellido";
            // 
            // button11
            // 
            button11.BackColor = Color.OliveDrab;
            button11.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.ForeColor = SystemColors.ControlLightLight;
            button11.Location = new Point(938, 6);
            button11.Name = "button11";
            button11.Size = new Size(40, 30);
            button11.TabIndex = 4;
            button11.Text = "➡️";
            button11.UseVisualStyleBackColor = false;
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(984, 661);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Empleado";
            Text = "EMPLEADO";
            Load += Form3_Load;
            Click += Form3_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TablaClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)TablaProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)TablaVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private DataGridView TablaProducto;
        private Label label2;
        private Button button6;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private Button button10;
        private TextBox textBox2;
        private DataGridView TablaVenta;
        private Button button7;
        private Button button1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label1;
        private DataGridView TablaClientes;
        private Label label7;
        private Label label6;
        private Button button2;
        private Label label8;
        private NumericUpDown numericUpDown1;
        private Button button8;
        private Label label10;
        private TextBox textBox9;
        private Label label13;
        private TextBox textBox6;
        private Label label12;
        private TextBox textBox5;
        private Label label11;
        private Label label21;
        private Button button11;
        private Button button3;
        private Button button9;
        private ComboBox comboBox4;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button5;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn cantidadProducto;
        private DataGridViewTextBoxColumn precioUnitario;
        private DataGridViewTextBoxColumn subTotal;
    }
}