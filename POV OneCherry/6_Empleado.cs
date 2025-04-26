using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POV_OneCherry
{
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void botonAgregarCliente(object sender, EventArgs e)
        {
            Form agregar = new RegistroCliente();
            agregar.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            // SQL query to fetch product data
            string query = "SELECT * FROM Clientes";
            using (SqlConnection connection = DBC.GlobalDBConnecion())
            {
                connection.Open();

                SqlDataAdapter adapter = DBC.CreateAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                TablaClientes.DataSource = dataTable;

                query = "SELECT Productos.ID_Productos AS ID_Prod, Productos.NombreProducto AS Nombre_Prod, Productos.Precio AS Precio, Productos.Stock AS Stock, Categorias.NombreCategoria AS Categoria FROM Productos " +
                    "JOIN Categorias ON Productos.ID_Categorias = Categorias.ID_Categorias";
                adapter = new SqlDataAdapter(query, connection);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                TablaProducto.DataSource = null; // Clear existing data source to avoid conflicts
                TablaProducto.DataSource = dataTable;

                connection.Close();
            }
        }

       
    }
}
