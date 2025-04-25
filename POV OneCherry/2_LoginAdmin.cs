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

        private void logIn(object sender, EventArgs e)
        {
            if (usrInput.Text != "admin")
            {
                MessageBox.Show("Usuario incorrecto");
                return;
            }
            if (pwdInput.Text != "root")
            {
                MessageBox.Show("Contraseña incorrecta");
                return;
            }
            Form log = new Administrador();
            log.Show();
            this.Hide();
            log.FormClosed += onClosedChild;
        }

        private void Salir(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void onClosedChild(object? sender, FormClosedEventArgs e)
        {
            usrInput.Clear();
            pwdInput.Clear();
            this.Show();
        }
    }
}
