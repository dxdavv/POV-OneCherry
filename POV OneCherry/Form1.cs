using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POV_OneCherry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "admin")
            {
                MessageBox.Show("Usuario incorrecto");
                return;
            }
            if (textBox2.Text != "root")
            {
                MessageBox.Show("Contraseña incorrecta");
                return;
            }
            MessageBox.Show("Sesion iniciada");

        }
    }
}
