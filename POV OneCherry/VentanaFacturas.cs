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
    public partial class VentanaFacturas : Form
    {
        private static string nombreSV = "BAN03";
        private static string DB = "PruebaPOS";
        private static string servidor = nombreSV + "\\SQLEXPRESS";
        private string connectionString = "Server=" + servidor + ";Database=" + DB + ";Trusted_Connection=True;";
        private string query = "SELECT CONCAT (Clientes.Nombre, ' ' ,Clientes.Apellido) AS Nombre_Cliente, Ventas.FechaVenta AS Fecha_Venta, " +
                "Productos.NombreProducto AS Productos, DetallesVenta.Cantidad, DetallesVenta.PrecioUnidad AS P_Unitario, " +
                "Promociones.NombrePromocion, Promociones.Descuento, Ventas.TotalVenta AS Total FROM DetallesVenta " +
                "JOIN Ventas ON DetallesVenta.ID_Ventas = Ventas.ID_Ventas " +
                "JOIN Clientes ON Ventas.ID_Clientes = Clientes.ID_Clientes " +
                "JOIN Promociones ON Ventas.ID_Promociones = Promociones.ID_Promociones " +
                "JOIN Productos ON DetallesVenta.ID_Productos = Productos.ID_Productos";
        private string[] columnas = { "Clientes.Nombre", "Clientes.Apellido", "Ventas.FechaVenta", "Productos.NombreProducto", "DetallesVenta.Cantidad", "DetallesVenta.PrecioUnidad", "Promociones.NombrePromocion", "Promociones.Descuento", "Ventas.TotalVenta" };
        private string[] filtros = { "Nombre_Cliente", "Fecha_Venta", "Productos", "Cantidad", "P_Unitario", "NombrePromocion", "Descuento", "Total" };
        public VentanaFacturas()
        {
            InitializeComponent();
        }

        private void VentanaFacturas_Load(object sender, EventArgs e)
        {
            // SQL query to fetch product data
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind data to the DataGridView
                TablaFacturas.DataSource = dataTable;
                connection.Close();
            }
        }
        private void Buscar(object sender, EventArgs e)
        {
            string nwquery = query;
            int seleccion = comboBox1.SelectedIndex;
            string ordenamiento = seleccion != -1 ? filtros[seleccion] : filtros[0];
            if (textBox1.Text.Length > 0)
            {
                string busqueda = textBox1.Text;
                nwquery += $" WHERE {columnas[0]} LIKE ('{busqueda}') OR " +
                    $"{columnas[1]} LIKE ('{busqueda}') OR " +
                    $"{columnas[2]} LIKE ('{busqueda}') OR " +
                    $"{columnas[3]} LIKE ('{busqueda}') OR " +
                    $"{columnas[4]} LIKE ('{busqueda}') OR " +
                    $"{columnas[5]} LIKE ('{busqueda}') OR " +
                    $"{columnas[6]} LIKE ('{busqueda}') OR " +
                    $"{columnas[7]} LIKE ('{busqueda}') OR " +
                    $"{columnas[8]} LIKE ('{busqueda}')";
            }
            nwquery += $" ORDER BY {ordenamiento}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(nwquery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                TablaFacturas.DataSource = null; // Clear existing data source to avoid conflicts

                // Bind data to the DataGridView
                TablaFacturas.DataSource = dataTable;
                connection.Close();

            }
        }

    }
}
