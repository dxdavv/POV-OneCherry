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

        private void btn_Login(object sender, EventArgs e)
        {
            if (inputUsr.Text != "def")
            {
                MessageBox.Show("Usuario incorrecto");
                return;
            }
            if (inputPwd.Text != "ault")
            {
                MessageBox.Show("Contraseña incorrecta");
                return;
            }
            Form empleado = new Empleado();
            this.Hide();
            empleado.Show();

            empleado.FormClosed += onChildClosed;
        }

        private void btn_Salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void onChildClosed(object sender, FormClosedEventArgs e)
        {
            inputUsr.Clear();
            inputPwd.Clear();
            this.Show();
        }
    }
}
