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
            splitContainer1 = new SplitContainer();
            label4 = new Label();
            splitContainer2 = new SplitContainer();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(label4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(884, 461);
            splitContainer1.SplitterDistance = 44;
            splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(797, 5);
            label4.Margin = new Padding(5);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 0;
            label4.Text = "One Cherry";
            label4.Click += label4_Click;
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
            splitContainer2.Panel1.Controls.Add(button2);
            splitContainer2.Panel1.Controls.Add(button1);
            splitContainer2.Panel1.Controls.Add(dataGridView1);
            splitContainer2.Panel1.Controls.Add(button3);
            splitContainer2.Panel1.Controls.Add(label1);
            splitContainer2.Panel1.Controls.Add(textBox1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.LavenderBlush;
            splitContainer2.Panel2.Controls.Add(label3);
            splitContainer2.Panel2.Controls.Add(label2);
            splitContainer2.Size = new Size(884, 413);
            splitContainer2.SplitterDistance = 422;
            splitContainer2.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(295, 349);
            button2.Name = "button2";
            button2.Size = new Size(117, 43);
            button2.TabIndex = 20;
            button2.Text = "Elegir cliente";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(10, 349);
            button1.Name = "button1";
            button1.Size = new Size(122, 43);
            button1.TabIndex = 19;
            button1.Text = "Agregar cliente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(402, 274);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(337, 33);
            button3.Name = "button3";
            button3.Size = new Size(75, 30);
            button3.TabIndex = 16;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Subheading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 17;
            label1.Text = "Buscar producto";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(10, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 23);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(140, 13);
            label3.Name = "label3";
            label3.Size = new Size(168, 24);
            label3.TabIndex = 15;
            label3.Text = "Nombre Apellido";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Subheading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 9);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 14;
            label2.Text = "Venta, cliente:";
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(884, 461);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Empleado";
            Text = "Empleado";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        protected internal Button button3;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}