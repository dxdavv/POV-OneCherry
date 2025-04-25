namespace POV_OneCherry
{
    partial class VentanaSoporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaSoporte));
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(74, 164);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 11;
            button2.Text = "Manual";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 19);
            label2.Name = "label2";
            label2.Size = new Size(194, 30);
            label2.TabIndex = 12;
            label2.Text = "Numero de contacto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 55);
            label1.Name = "label1";
            label1.Size = new Size(110, 22);
            label1.TabIndex = 13;
            label1.Text = "7791080376";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(74, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Goudy Old Style", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 95);
            label3.Name = "label3";
            label3.Size = new Size(110, 22);
            label3.TabIndex = 16;
            label3.Text = "5584472125";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(2, 131);
            label4.Name = "label4";
            label4.Size = new Size(180, 30);
            label4.TabIndex = 17;
            label4.Text = "Acceder al manual:";
            // 
            // VentanaSoporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(284, 211);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(300, 250);
            MinimumSize = new Size(300, 250);
            Name = "VentanaSoporte";
            Text = "SOPORTE";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
    }
}