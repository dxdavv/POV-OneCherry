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
    public partial class VentanaPromociones : Form
    {
        private static string nombreSV = "BAN03";
        private static string DB = "PruebaPOS";
        private static string servidor = nombreSV + "\\SQLEXPRESS";
        private string connectionString = "Server=" + servidor + ";Database=" + DB + ";Trusted_Connection=True;";
        private string query = "SELECT ID_Promociones AS ID, FechaPromocion AS Fecha_Termino, NombrePromocion AS Nombre, Descuento FROM Promociones";
        private string[] columnas = { "ID_Promociones", "NombrePromocion", "FechaPromocion", "Descuento" };
        private string IdACambiar = "";
        public VentanaPromociones()
        {
            InitializeComponent();
        }

        private void VentanaPromociones_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                TablaPromociones.DataSource = null; // Clear existing data source to avoid conflicts

                // Bind data to the DataGridView
                TablaPromociones.DataSource = dataTable;
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
                nwquery += $" WHERE {columnas[1]} LIKE ('{busqueda}') OR " +
                    $"{columnas[2]} LIKE ('{busqueda}') OR " +
                    $"{columnas[3]} LIKE ('{busqueda}')";
            }
            nwquery += $" ORDER BY {ordenamiento}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(nwquery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                TablaPromociones.DataSource = null; // Clear existing data source to avoid conflicts

                // Bind data to the DataGridView
                TablaPromociones.DataSource = dataTable;
                connection.Close();

            }
            textBox1.Clear();
        }
        private void Agregar(object sender, EventArgs e)
        {
            string nwquery = $"INSERT INTO Promociones ({columnas[1]}, {columnas[2]}, {columnas[3]}) VALUES (@valor1, @fecha, @valor3)";

            if (textBox2.Text.Length > 0 && textBox5.Text.Length > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(nwquery, connection))
                {
                    cmd.Parameters.AddWithValue("@valor1", textBox2.Text);
                    cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@valor3", decimal.Parse(textBox5.Text)); // Si es numérico

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Agregado Exitosamente!");
                        VentanaPromociones_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el registro.");
                    }
                }
            }
        }
        private void MandarAEditar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdACambiar = TablaPromociones.Rows[e.RowIndex].Cells[0].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(TablaPromociones.Rows[e.RowIndex].Cells[1].Value);
                textBox2.Text = TablaPromociones.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox5.Text = TablaPromociones.Rows[e.RowIndex].Cells[3].Value.ToString();
                
            }
        }
        private void Editar(object sender, EventArgs e)
        {
            int seleccion = comboBox1.SelectedIndex;

            if (textBox2.Text.Length > 0 && textBox5.Text.Length > 0)
            {
                string nwquery = "UPDATE Promociones SET " +
                                 $"{columnas[1]} = @valor1, {columnas[2]} = @fecha, {columnas[3]} = @valor3 " +
                                 "WHERE ID_Promociones = @id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(nwquery, conn))
                {
                    // Asignar parámetros de forma segura
                    cmd.Parameters.AddWithValue("@valor1", textBox2.Text);
                    cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.Date); // ✅ Fecha correcta
                    cmd.Parameters.AddWithValue("@valor3", decimal.Parse(textBox5.Text)); // ✅ Convertir si es número
                    cmd.Parameters.AddWithValue("@id", int.Parse(IdACambiar)); // ✅ ID de la promoción

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    // Limpiar campos
                    textBox2.Clear();
                    textBox5.Clear();

                    if (rowsAffected > 0)
                    {
                        VentanaPromociones_Load(sender, e); // Recargar tabla
                        MessageBox.Show("Registro actualizado correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar llenos antes de editar.");
            }
        }
        private void Eliminar(object sender, EventArgs e)
        {
            string nwquery;
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            if (textBox2.Text.Length > 0 && textBox5.Text.Length > 0 && !IdACambiar.Equals(""))
            {
                nwquery = $"DELETE FROM Promociones WHERE ID_Promociones = {IdACambiar}";
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
                        VentanaPromociones_Load(sender, e);
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
