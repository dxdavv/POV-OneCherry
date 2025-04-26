using DocumentFormat.OpenXml.Wordprocessing;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace POV_OneCherry
{
    public partial class Usuarios : Form
    {
        private static string nombreSV = "ANG";
        private static string DB = "PruebaPOS";

        private static string servidor = nombreSV + "\\SQLEXPRESS";
        private string connectionString = "Server=" + servidor + ";Database=" + DB + ";Trusted_Connection=True;";
        private string query = "SELECT * FROM Usuarios";
        private string[] filtros = { "NombreUsuario" , "Pin" , "Tipo" };
        private string[] tipos = { "Administrador", "Empleado" };
        private string IdACambiar = "";

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

            // SQL query to fetch product data
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                TablaUsuarios.DataSource = null; // Clear existing data source to avoid conflicts

                // Bind data to the DataGridView
                TablaUsuarios.DataSource = dataTable;
                connection.Close();

            }
        }
        private void Buscar(object sender, EventArgs e)
        {
            string nwquery = query;
            int seleccion = comboBox2.SelectedIndex;
            string ordenamiento = seleccion > 0 ? filtros[seleccion] : filtros[0];
            nwquery += $" ORDER BY {ordenamiento}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(nwquery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                TablaUsuarios.DataSource = null; // Clear existing data source to avoid conflicts

                // Bind data to the DataGridView
                TablaUsuarios.DataSource = dataTable;
                connection.Close();

            }
        }
        private void Agregar(object sender, EventArgs e)
        {
            string nwquery;
            int seleccion = comboBox1.SelectedIndex;
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && seleccion > -1)
            {
                nwquery = "INSERT INTO Usuarios (NombreUsuario, Pin, Tipo) " +
                    $"VALUES ('{textBox2.Text}', {textBox3.Text}, '{tipos[seleccion]}')";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using(SqlCommand cmd = new SqlCommand(nwquery, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Agregado Exitosamente");
                    }
                }
            }
            Usuarios_Load(sender, e);
        }
        private void MandarAEditar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdACambiar = TablaUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = TablaUsuarios.Rows[e.RowIndex].Cells[filtros[0]].Value.ToString();
                textBox3.Text = TablaUsuarios.Rows[e.RowIndex].Cells[filtros[1]].Value.ToString();
                comboBox1.SelectedIndex = Array.IndexOf(tipos, TablaUsuarios.Rows[e.RowIndex].Cells[filtros[2]].Value.ToString());

            }
        }
        private void Editar (object sender, EventArgs e)
        {
            int seleccion = comboBox1.SelectedIndex;
            string nwquery;
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && seleccion > -1)
            {
                nwquery = "UPDATE Usuarios SET " +
                    $"{filtros[0]}='{textBox2.Text}', {filtros[1]}={textBox3.Text}, {filtros[2]}='{tipos[comboBox1.SelectedIndex]}' WHERE ID_Usuarios = {IdACambiar}";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(nwquery, conn))
                {

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    textBox2.Clear();
                    textBox3.Clear();
                    comboBox1.SelectedIndex = -1;

                    if (rowsAffected > 0)
                    {
                        Usuarios_Load(sender, e);
                        MessageBox.Show("Registro actualizado correctamente!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro.");
                    }
                }
            }
            Usuarios_Load (sender, e);
        }
        private void Eliminar(object sender, EventArgs e)
        {
            int seleccion = comboBox1.SelectedIndex;
            string nwquery;
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && seleccion > -1 && !IdACambiar.Equals(""))
            {
                nwquery = $"DELETE FROM Usuarios WHERE ID_Usuarios = {IdACambiar}";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(nwquery, conn))
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    textBox2.Clear();
                    textBox3.Clear();
                    comboBox1.SelectedIndex = -1;

                    if (rowsAffected > 0)
                    {
                        Usuarios_Load(sender, e);
                        MessageBox.Show("Registro eliminado correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro.");
                    }
                }
            }
        }
    }
}
