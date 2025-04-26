using ClosedXML.Excel;
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
    public partial class VentanaVenta : Form
    {
        private static string nombreSV = "ANG";
        private static string DB = "PruebaPOS";
        private static string servidor = nombreSV + "\\SQLEXPRESS";
        private string connectionString = "Server=" + servidor + ";Database=" + DB + ";Trusted_Connection=True;";

        private string query = "SELECT Ventas.ID_Ventas AS ID_Venta, Usuarios.NombreUsuario AS Usuario, Ventas.FechaVenta AS Fecha, " +
                "CONCAT (Clientes.Nombre, ' ' ,Clientes.Apellido) AS Nombre_Cliente, Ventas.TotalVenta AS Total, Promociones.NombrePromocion FROM Ventas " +
                "JOIN Clientes ON Ventas.ID_Clientes = Clientes.ID_Clientes  " +
                "JOIN Promociones ON Ventas.ID_Promociones = Promociones.ID_Promociones " +
                "JOIN Usuarios ON Ventas.ID_Usuarios = Usuarios.ID_Usuarios";
        private string[] columnas = { "Ventas.ID_Ventas", "Ventas.FechaVenta", "Ventas.TotalVenta", "Ventas.ID_Clientes", "Ventas.ID_Usuarios", "Ventas.ID_Promociones" };
        public VentanaVenta()
        {
            InitializeComponent();
        }

        private void onCloseChild(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void botonFacturas(object sender, EventArgs e)
        {
            Form facturas = new VentanaFacturas();
            facturas.Show();
            this.Hide();
            facturas.FormClosed += onCloseChild;
        }

        private void VentanaVenta_Load(object sender, EventArgs e)
        {
            // SQL query to fetch product data
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = null; // Clear existing data source to avoid conflicts

                // Bind data to the DataGridView
                dataGridView1.DataSource = dataTable;
                connection.Close();

            }
        }
        private void Buscar(object sender, EventArgs e)
        {
            string nwquery = query;
            int seleccion = comboBox1.SelectedIndex;
            string ordenamiento = columnas[seleccion];
            if (textBox1.Text.Length > 0)
            {
                string busqueda = textBox1.Text;
                nwquery += $" WHERE Ventas.ID_Ventas LIKE ('{busqueda}') OR " +
                    $"Usuarios.NombreUsuario LIKE ('{busqueda}') OR " +
                    $"Ventas.FechaVenta LIKE ('{busqueda}') OR " +
                    $"Clientes.Nombre LIKE ('{busqueda}') OR " +
                    $"Clientes.Apellido LIKE ('{busqueda}') OR " +
                    $"Ventas.TotalVenta LIKE ({busqueda}) OR " +
                    $"Promociones.NombrePromocion LIKE ('{busqueda}')";
            }
            nwquery += $" ORDER BY {ordenamiento}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(nwquery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = null; // Clear existing data source to avoid conflicts

                // Bind data to the DataGridView
                dataGridView1.DataSource = dataTable;
                connection.Close();

            }
            textBox1.Clear();
        }
        private void ToExcel (object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "Excel Files|*.xlsx";
                        sfd.Title = "Guardar Excel";
                        sfd.FileName = "Ventas.xlsx";

                        if (sfd.ShowDialog() == DialogResult.OK) // User selects a location
                        {
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                var worksheet = workbook.Worksheets.Add(dt, "Todas las ventas");
                                workbook.SaveAs(sfd.FileName);
                            }

                            MessageBox.Show("El Excel se guardo correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
