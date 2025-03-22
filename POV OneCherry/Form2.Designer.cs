namespace POV_OneCherry
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            splitContainer1 = new SplitContainer();
            ButtonProveedor = new Button();
            button3 = new Button();
            Productos = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            splitContainer1.Size = new Size(884, 461);
            splitContainer1.SplitterDistance = 104;
            splitContainer1.TabIndex = 0;
            // 
            // ButtonProveedor
            // 
            ButtonProveedor.Location = new Point(1, 45);
            ButtonProveedor.Name = "ButtonProveedor";
            ButtonProveedor.Size = new Size(102, 30);
            ButtonProveedor.TabIndex = 0;
            ButtonProveedor.Text = "Proveedores";
            ButtonProveedor.UseVisualStyleBackColor = true;
            ButtonProveedor.Click += ButtonProveedor_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1, 105);
            button3.Name = "button3";
            button3.Size = new Size(102, 30);
            button3.TabIndex = 2;
            button3.Text = "Empleados";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Productos
            // 
            Productos.Location = new Point(1, 135);
            Productos.Name = "Productos";
            Productos.Size = new Size(102, 30);
            Productos.TabIndex = 3;
            Productos.Text = "Productos";
            Productos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1, 430);
            button1.Name = "button1";
            button1.Size = new Size(102, 30);
            button1.TabIndex = 4;
            button1.Text = "Soporte";
            button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            button2.Location = new Point(1, 75);
            button2.Name = "button2";
            button2.Size = new Size(102, 30);
            button2.TabIndex = 1;
            button2.Text = "Clientes";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1, 165);
            button4.Name = "button4";
            button4.Size = new Size(102, 30);
            button4.TabIndex = 6;
            button4.Text = "Ventas";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(splitContainer1);
            MaximumSize = new Size(900, 500);
            MinimumSize = new Size(900, 500);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            Load += Form2_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}