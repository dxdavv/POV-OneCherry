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
    public partial class VentanaComprasProv : Form
    {
        private static string nombreSV = "BAN03";
        private static string DB = "PruebaPOS";

        private static string servidor = nombreSV + "\\SQLEXPRESS";
        private string connectionString = "Server=" + servidor + ";Database=" + DB + ";Trusted_Connection=True;";
        private string query = "SELECT ComprasProveedor.ID_ComprasProveedor AS ID_Compra, ComprasProveedor.FechaCompra AS Fecha_Compra, " +
                "Proveedores.NombreProveedor AS Proveedor, Productos.NombreProducto AS Productos, DetallesCompra.Cantidad, " +
                "DetallesCompra.PrecioUnidad AS P_Unitario, ComprasProveedor.PrecioTotal AS P_Total FROM DetallesCompra " +
                "JOIN Productos ON DetallesCompra.ID_Productos = Productos.ID_Productos " +
                "JOIN ComprasProveedor ON DetallesCompra.ID_ComprasProveedor = ComprasProveedor.ID_ComprasProveedor " +
                "JOIN Proveedores ON ComprasProveedor.ID_Proveedores = Proveedores.ID_Proveedores";
        private string[] columnas = { "ComprasProveedor.ID_ComprasProveedor" , "ComprasProveedor.FechaCompra", "Proveedores.NombreProveedor", "Productos.NombreProducto", "DetallesCompra.Cantidad", "DetallesCompra.PrecioUnidad", "ComprasProveedor.PrecioTotal" };
        public VentanaComprasProv()
        {
            InitializeComponent();
        }

        private void VentanaComprasProv_Load(object sender, EventArgs e)
        {
            // SQL query to fetch product data
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                TablaCompras.DataSource = null; // Clear existing data source to avoid conflicts

                // Bind data to the DataGridView
                TablaCompras.DataSource = dataTable;
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
                    $"{columnas[1]} LIKE ('{busqueda}') OR " +
                    $"{columnas[2]} LIKE ('{busqueda}') OR " +
                    $"{columnas[3]} LIKE ('{busqueda}') OR " +
                    $"{columnas[4]} LIKE ('{busqueda}') OR " +
                    $"{columnas[5]} LIKE ('{busqueda}') OR " +
                    $"{columnas[6]} LIKE ('{busqueda}')";
            }
            nwquery += $" ORDER BY {ordenamiento}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(nwquery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                TablaCompras.DataSource = null; // Clear existing data source to avoid conflicts

                // Bind data to the DataGridView
                TablaCompras.DataSource = dataTable;
                connection.Close();

            }
            textBox1.Clear();
        }
        private void ToExcel(object sender, EventArgs e)
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
                        sfd.FileName = "Poveedor.xlsx";

                        if (sfd.ShowDialog() == DialogResult.OK) // User selects a location
                        {
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                var worksheet = workbook.Worksheets.Add(dt, "Todas las compras a proveedor");
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
