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

        private void logIn(object sender, EventArgs e)
        {
            if (usrText.Text != "def")
            {
                MessageBox.Show("Usuario incorrecto");
                return;
            }
            if (pwdText.Text != "ault")
            {
                MessageBox.Show("Contraseña incorrecta");
                return;
            }
            Form log = new Empleado();
            log.Show();
            this.Hide();
            log.FormClosed += onClosedChild;
        }

        private void onClosedChild(object? sender, FormClosedEventArgs e)
        {
            usrText.Clear();
            pwdText.Clear();
            this.Show();
        }

        private void Salir(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
