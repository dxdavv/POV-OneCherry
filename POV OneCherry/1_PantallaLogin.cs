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
        
        private void btn_admin(object sender, EventArgs e)
        {
            Form admin = new LoginAdmin();
            this.Hide();
            admin.Show();

            admin.FormClosing += onCloseChild;
        }

        private void btn_empleado(object sender, EventArgs e)
        {
            Form empleado = new LoginEmpleado();
            this.Hide();
            empleado.Show();

            empleado.FormClosing += onCloseChild;
        }

        private void btn_salir(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void onCloseChild(object? sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
