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
        
            string nombreSV = "ANG";
            string servidor = nombreSV + "\\SQLEXPRESS";
            string DB = "PruebaPOS";

            string connectionString = "Server=" + servidor + ";Database=" + DB + ";Trusted_Connection=True;";

            // SQL query to fetch product data
            string query = "SELECT Ventas.ID_Ventas AS ID_Venta, Usuarios.NombreUsuario AS Usuario, Ventas.FechaVenta AS Fecha, " +
                "CONCAT (Clientes.Nombre, ' ' ,Clientes.Apellido) AS Nombre_Cliente, Ventas.TotalVenta AS Total, Promociones.NombrePromocion FROM Ventas " +
                "JOIN Clientes ON Ventas.ID_Clientes = Clientes.ID_Clientes  " +
                "JOIN Promociones ON Ventas.ID_Promociones = Promociones.ID_Promociones " +
                "JOIN Usuarios ON Ventas.ID_Usuarios = Usuarios.ID_Usuarios";
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
    }
}
