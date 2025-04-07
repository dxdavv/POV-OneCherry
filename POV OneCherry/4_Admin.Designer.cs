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
            button5 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            Productos = new Button();
            button3 = new Button();
            button2 = new Button();
            ButtonProveedor = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            button9 = new Button();
            button8 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            splitContainer1.Panel2.Controls.Add(textBox6);
            splitContainer1.Panel2.Controls.Add(textBox5);
            splitContainer1.Panel2.Controls.Add(textBox4);
            splitContainer1.Panel2.Controls.Add(textBox3);
            splitContainer1.Panel2.Controls.Add(button9);
            splitContainer1.Panel2.Controls.Add(button8);
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(button7);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(button6);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Size = new Size(884, 461);
            splitContainer1.SplitterDistance = 103;
            splitContainer1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(1, 195);
            button5.Name = "button5";
            button5.Size = new Size(102, 30);
            button5.TabIndex = 7;
            button5.Text = "Usuarios";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(1, 165);
            button4.Name = "button4";
            button4.Size = new Size(102, 30);
            button4.TabIndex = 6;
            button4.Text = "Ventas";
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
            button1.Size = new Size(102, 30);
            button1.TabIndex = 4;
            button1.Text = "Soporte";
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
            Productos.Size = new Size(102, 30);
            Productos.TabIndex = 3;
            Productos.Text = "Productos";
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
            button3.Size = new Size(102, 30);
            button3.TabIndex = 2;
            button3.Text = "Empleados";
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
            button2.Size = new Size(102, 30);
            button2.TabIndex = 1;
            button2.Text = "Clientes";
            button2.UseVisualStyleBackColor = false;
            // 
            // ButtonProveedor
            // 
            ButtonProveedor.BackColor = Color.Crimson;
            ButtonProveedor.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonProveedor.ForeColor = SystemColors.ControlLightLight;
            ButtonProveedor.Location = new Point(1, 45);
            ButtonProveedor.Name = "ButtonProveedor";
            ButtonProveedor.Size = new Size(102, 30);
            ButtonProveedor.TabIndex = 0;
            ButtonProveedor.Text = "Proveedores";
            ButtonProveedor.UseVisualStyleBackColor = false;
            ButtonProveedor.Click += ButtonProveedor_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(223, 340);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(182, 23);
            textBox6.TabIndex = 29;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(14, 340);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(182, 23);
            textBox5.TabIndex = 28;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(571, 340);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(182, 23);
            textBox4.TabIndex = 27;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(571, 287);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 23);
            textBox3.TabIndex = 26;
            // 
            // button9
            // 
            button9.BackColor = Color.Crimson;
            button9.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(470, 406);
            button9.Name = "button9";
            button9.Size = new Size(161, 43);
            button9.TabIndex = 25;
            button9.Text = "Eliminar usuario";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(284, 406);
            button8.Name = "button8";
            button8.Size = new Size(161, 43);
            button8.TabIndex = 24;
            button8.Text = "Editar usuario";
            button8.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(223, 287);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 23);
            textBox2.TabIndex = 23;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 287);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 22;
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
            button7.Text = "Agregar usuario";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(750, 199);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 14);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(166, 33);
            label1.TabIndex = 3;
            label1.Text = "USUARIOS";
            label1.Click += label1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.OliveDrab;
            button6.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(725, 3);
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
            label4.Location = new Point(571, 2);
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
            ClientSize = new Size(884, 461);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(900, 500);
            MinimumSize = new Size(900, 500);
            Name = "Administrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
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
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button9;
        private Button button8;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
    }
}