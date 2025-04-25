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
        public VentanaFacturas()
        {
            InitializeComponent();
        }

        private void VentanaFacturas_Load(object sender, EventArgs e)
        {
            string nombreSV = "ANG";
            string servidor = nombreSV + "\\SQLEXPRESS";
            string DB = "PruebaPOS";

            string connectionString = "Server=" + servidor + ";Database=" + DB + ";Trusted_Connection=True;";

            // SQL query to fetch product data
            string query = "SELECT CONCAT (Clientes.Nombre, ' ' ,Clientes.Apellido) AS Nombre_Cliente, Ventas.FechaVenta AS Fecha_Venta, " +
                "Productos.NombreProducto AS Productos, DetallesVenta.Cantidad, DetallesVenta.PrecioUnidad AS P_Unitario, " +
                "Promociones.NombrePromocion, Promociones.Descuento, Ventas.TotalVenta AS Total FROM DetallesVenta " +
                "JOIN Ventas ON DetallesVenta.ID_Ventas = Ventas.ID_Ventas " +
                "JOIN Clientes ON Ventas.ID_Clientes = Clientes.ID_Clientes " +
                "JOIN Promociones ON Ventas.ID_Promociones = Promociones.ID_Promociones " +
                "JOIN Productos ON DetallesVenta.ID_Productos = Productos.ID_Productos"; 


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
    }
}
