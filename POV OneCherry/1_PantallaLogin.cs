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
    public partial class PrimerPantallaLogin : Form
    {
        public PrimerPantallaLogin()
        {
            InitializeComponent();
        }


        private void Salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonAdmin(object sender, EventArgs e)
        {
            Form admin = new LoginAdmin();
            admin.Show();
            this.Hide();
            admin.FormClosed += onCloseChild;
        }

        private void botonEmpleado(object sender, EventArgs e)
        {
            Form empleado = new LoginEmpleado();
            empleado.Show();
            this.Hide();
            empleado.FormClosed += onCloseChild;
        }
        private void onCloseChild(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

    }
}
