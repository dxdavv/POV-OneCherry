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

        private void btn_Login(object sender, EventArgs e)
        {
            if (inputUsr.Text != "admin")
            {
                MessageBox.Show("Usuario incorrecto");
                return;
            }
            if (inputPwd.Text != "root")
            {
                MessageBox.Show("Contraseña incorrecta");
                return;
            }
            Form admin = new Administrador();
            admin.Show();
            this.Hide();

            admin.FormClosed += onClosedChild;
        }

        private void btn_Salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void onClosedChild(object? sender, FormClosedEventArgs e)
        {
            inputUsr.Clear();
            inputPwd.Clear();
            this.Show();
        }
    }
}
