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
            if (usrInput.Text.Length < 1 && pwdInput.Text.Length < 1)
            {
                return;
            }
            if (!AutenticarUsuario(usrInput.Text, pwdInput.Text))
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
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
        
        static bool AutenticarUsuario(string usuario, string contraseña)
        {
            string nombreSV = "BAN03";
            string DB = "PruebaPOS";
            string servidor = nombreSV + "\\SQLEXPRESS";
            string connectionString = "Server=" + servidor + ";Database=" + DB + ";Trusted_Connection=True;";

            string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @usuario AND Pin = @contraseña AND Tipo = 'Administrador'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();

                return count > 0;
            }
        }
    }
}
