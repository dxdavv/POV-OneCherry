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
        public RegistroCliente()
        {
            InitializeComponent();
        }
        private void Agregar(object sender, EventArgs e)
        {
                string query = "INSERT INTO Clientes (Nombre, Apellido, Email, Telefono) " +
                    $"VALUES ('{textBox1.Text}', '{textBox4.Text}', '{textBox2.Text}', '{textBox3.Text}')";
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0)
            {
                if (DBC.EditData(query) > 0)
                {
                    MessageBox.Show("Agregado Exitosamente");
                }
            }
        }
    }
}
