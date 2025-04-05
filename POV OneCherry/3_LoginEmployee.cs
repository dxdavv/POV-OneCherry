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
    public partial class LoginEmpleado : Form
    {
        public LoginEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "def")
            {
                MessageBox.Show("Usuario incorrecto");
                return;
            }
            if (textBox2.Text != "ault")
            {
                MessageBox.Show("Contraseña incorrecta");
                return;
            }
            new Empleado().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
