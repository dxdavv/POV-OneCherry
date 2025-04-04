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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
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
            // this.SendToBack();
            // this.SendToBack(); oculta esta ventana para no estorbar en las demas
            new Administrador().ShowDialog();
            // este new Form2().Show(); es para usar la ventan siguiente
            // sin tener que crear un objeto y se utiliza Show()
            // para que se muestre
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
