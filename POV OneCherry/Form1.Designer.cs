namespace POV_OneCherry
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(176, 15);
            label1.MaximumSize = new Size(248, 37);
            label1.MinimumSize = new Size(248, 37);
            label1.Name = "label1";
            label1.Size = new Size(248, 37);
            label1.TabIndex = 0;
            label1.Text = "ONE CHERRY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Old Style", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(182, 120);
            label2.Name = "label2";
            label2.Size = new Size(98, 30);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Goudy Old Style", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(182, 185);
            label3.Name = "label3";
            label3.Size = new Size(140, 31);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.Font = new Font("Goudy Old Style", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(355, 309);
            button1.Name = "button1";
            button1.Size = new Size(100, 25);
            button1.TabIndex = 3;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Pink;
            button2.Font = new Font("Goudy Old Style", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(464, 309);
            button2.Name = "button2";
            button2.Size = new Size(100, 25);
            button2.TabIndex = 4;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = Properties.Resources.perrito;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(25, 106);
            pictureBox1.MaximumSize = new Size(140, 121);
            pictureBox1.MinimumSize = new Size(140, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightPink;
            textBox1.Location = new Point(286, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightPink;
            textBox2.Location = new Point(328, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 23);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(584, 361);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private PictureBox pictureBox1;
        protected internal Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}