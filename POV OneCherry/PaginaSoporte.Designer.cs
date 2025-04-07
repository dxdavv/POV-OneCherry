namespace POV_OneCherry
{
    partial class PaginaSoporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaSoporte));
            btnManual = new Button();
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
            // btnManual
            // 
            btnManual.BackColor = Color.Crimson;
            btnManual.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManual.ForeColor = SystemColors.ControlLightLight;
            btnManual.Location = new Point(74, 164);
            btnManual.Name = "btnManual";
            btnManual.Size = new Size(75, 35);
            btnManual.TabIndex = 11;
            btnManual.Text = "Manual";
            btnManual.UseVisualStyleBackColor = false;
            btnManual.Click += btn_Manual;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 21);
            label2.Name = "label2";
            label2.Size = new Size(187, 24);
            label2.TabIndex = 12;
            label2.Text = "Numero de contacto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 55);
            label1.Name = "label1";
            label1.Size = new Size(110, 24);
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
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 95);
            label3.Name = "label3";
            label3.Size = new Size(110, 24);
            label3.TabIndex = 16;
            label3.Text = "5584472125";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 137);
            label4.Name = "label4";
            label4.Size = new Size(173, 24);
            label4.TabIndex = 17;
            label4.Text = "Acceder al manual:";
            // 
            // PaginaSoporte
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
            Controls.Add(btnManual);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(300, 250);
            MinimumSize = new Size(300, 250);
            Name = "PaginaSoporte";
            Text = "Soporte";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManual;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
    }
}