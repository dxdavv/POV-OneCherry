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
    public partial class RegistroCliente : Form
    {
        private static string nombreSV = "BAN03";
        private static string DB = "PruebaPOS";

        private static string servidor = nombreSV + "\\SQLEXPRESS";
        private string connectionString = "Server=" + servidor + ";Database=" + DB + ";Trusted_Connection=True;";

        public RegistroCliente()
        {
            InitializeComponent();
        }
        private void Agregar(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0)
            {
                string query = "INSERT INTO Clientes (Nombre, Apellido, Email, Telefono) " +
                    $"VALUES ('{textBox1.Text}', '{textBox4.Text}', '{textBox2.Text}', {textBox3.Text})";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Agregado Exitosamente");
                    }
                }
            }
        }
    }
}
