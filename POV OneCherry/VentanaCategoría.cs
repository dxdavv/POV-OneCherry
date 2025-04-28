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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace POV_OneCherry
{
    public partial class VentanaCategoría : Form
    {
        private static string nombreSV = "BAN03";
        private static string DB = "PruebaPOS";
        private static string servidor = nombreSV + "\\SQLEXPRESS";
        private string connectionString = "Server=" + servidor + ";Database=" + DB + ";Trusted_Connection=True;";
        private string query = "SELECT ID_Categorias AS ID_Cat, NombreCategoria AS Categoria FROM Categorias";
        private string[] columnas = { "ID_Categorias", "NombreCategoria" };
        private string IdACambiar = "";

        public VentanaCategoría()
        {
            InitializeComponent();
        }

        private void VentanaCategoría_Load(object sender, EventArgs e)
        {
            // SQL query to fetch product data
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                TablaCategorias.DataSource = null; // Clear existing data source to avoid conflicts

                // Bind data to the DataGridView
                TablaCategorias.DataSource = dataTable;
                connection.Close();

            }
        }
        private void Buscar(object sender, EventArgs e)
        {
            string nwquery = query;
            int seleccion = comboBox1.SelectedIndex;
            string ordenamiento = seleccion != -1 ? columnas[seleccion] : columnas[0];
            if (textBox1.Text.Length > 0)
            {
                string busqueda = textBox1.Text;
                nwquery += $" WHERE {columnas[0]} LIKE ('{busqueda}') OR " +
                    $"{columnas[1]} LIKE ('{busqueda}')";
                MessageBox.Show(nwquery);
            }
            nwquery += $" ORDER BY {ordenamiento}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(nwquery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                TablaCategorias.DataSource = null; // Clear existing data source to avoid conflicts

                // Bind data to the DataGridView
                TablaCategorias.DataSource = dataTable;
                connection.Close();

            }
        }
        private void Agregar(object sender, EventArgs e)
        {
            string nwquery;
            if (textBox2.Text.Length > 0)
            {
                nwquery = "INSERT INTO Categorias (NombreCategoria) " +
                    $"VALUES ('{textBox2.Text}')";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(nwquery, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Agregado Exitosamente");
                    }
                }
            }
            VentanaCategoría_Load(sender, e);
        }
        private void MandarAEditar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdACambiar = TablaCategorias.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = TablaCategorias.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
        }
        private void Editar(object sender, EventArgs e)
        {
            int seleccion = comboBox1.SelectedIndex;
            string nwquery;
            if (textBox2.Text.Length > 0)
            {
                nwquery = "UPDATE Categorias SET " +
                    $"{columnas[1]}='{textBox2.Text}' WHERE ID_Categorias = {IdACambiar}";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(nwquery, conn))
                {

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    textBox2.Clear();

                    if (rowsAffected > 0)
                    {
                        VentanaCategoría_Load(sender, e);
                        MessageBox.Show("Registro actualizado correctamente!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro.");
                    }
                }
            }
            VentanaCategoría_Load(sender, e);
        }
        private void Eliminar(object sender, EventArgs e)
        {
            string nwquery;
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            if (textBox2.Text.Length > 0 && !IdACambiar.Equals(""))
            {
                nwquery = $"DELETE FROM Categorias WHERE ID_Categorias = {IdACambiar}";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(nwquery, conn))
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    textBox2.Clear();

                    if (rowsAffected > 0)
                    {
                        VentanaCategoría_Load(sender, e);
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
