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
    public partial class VentanaProductos : Form
    {
        public VentanaProductos()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string nombreSV = "ANG";
            string servidor = nombreSV + "\\SQLEXPRESS";
            string DB = "PruebaPOS";

            string connectionString = "Server=" + servidor + ";Database=" + DB + ";Trusted_Connection=True;";

            // SQL query to fetch product data
            string query = "SELECT Productos.ID_Productos AS ID_Prod, Productos.NombreProducto AS Nombre_Prod, Productos.Precio AS Precio, Productos.Stock AS Stock, Categorias.NombreCategoria AS Categoria FROM Productos " +
                "JOIN Categorias ON Productos.ID_Categorias = Categorias.ID_Categorias";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind data to the DataGridView
                TablaProductos.DataSource = dataTable;
                connection.Close();
            }
        }

        private void onCloseChild(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void botonCategorias(object sender, EventArgs e)
        {
            Form categorias = new VentanaCategoría();
            categorias.Show();
            this.Hide();
            categorias.FormClosed += onCloseChild;
        }
    }
}
