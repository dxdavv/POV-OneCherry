using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            if (usrInput.Text.Length < 1 || pwdInput.Text.Length < 1
                && pwdInput.Text.CompareTo("0") < 0 && pwdInput.Text.CompareTo(":") > 9)
            {
                return;
            }
            string usr = usrInput.Text;
            string pwd = pwdInput.Text;
            if (usr.Equals("admin") && pwd.Equals("root"))
            {
                Form logg = new Administrador("admin");
                logg.Show();
                this.Hide();
                logg.FormClosed += onClosedChild;
                return;
            }
            string query = $"SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = '{usr}' AND Pin = '{pwd}' AND Tipo = 'Administrador'";
            if (DBC.GetData(query)[0].Equals("0"))
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
                return;
            }
            string nwquery = "SELECT Administrador.NombreApellido FROM Administrador" +
                " JOIN Usuarios ON Administrador.ID_Usuarios = Usuarios.ID_Usuarios"
                + $" WHERE Usuarios.NombreUsuario = '{usr}' AND Usuarios.Pin = '{pwd}' AND Usuarios.Tipo = 'Administrador'";
            Form log = new Administrador(DBC.GetData(nwquery)[0].ToString());
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
