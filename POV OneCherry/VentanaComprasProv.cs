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
        public VentanaComprasProv()
        {
            InitializeComponent();
        }

        private void VentanaComprasProv_Load(object sender, EventArgs e)
        {
            string nombreSV = "ANG";
            string servidor = nombreSV + "\\SQLEXPRESS";
            string DB = "PruebaPOS";

            string connectionString = "Server=" + servidor + ";Database=" + DB + ";Trusted_Connection=True;";

            // SQL query to fetch product data
            string query = "SELECT ComprasProveedor.ID_ComprasProveedor AS ID_Compra, ComprasProveedor.FechaCompra AS Fecha_Compra, " +
                "Proveedores.NombreProveedor AS Proveedor, Productos.NombreProducto AS Productos, DetallesCompra.Cantidad, " +
                "DetallesCompra.PrecioUnidad AS P_Unitario, ComprasProveedor.PrecioTotal AS P_Total FROM DetallesCompra " +
                "JOIN Productos ON DetallesCompra.ID_Productos = Productos.ID_Productos " +
                "JOIN ComprasProveedor ON DetallesCompra.ID_ComprasProveedor = ComprasProveedor.ID_ComprasProveedor " +
                "JOIN Proveedores ON ComprasProveedor.ID_Proveedores = Proveedores.ID_Proveedores";
                ;
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
    }
}
