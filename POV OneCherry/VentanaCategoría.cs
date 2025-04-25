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
    public partial class VentanaCategoría : Form
    {
        public VentanaCategoría()
        {
            InitializeComponent();
        }

        private void VentanaCategoría_Load(object sender, EventArgs e)
        {
            string nombreSV = "ANG";
            string servidor = nombreSV + "\\SQLEXPRESS";
            string DB = "PruebaPOS";

            string connectionString = "Server=" + servidor + ";Database=" + DB + ";Trusted_Connection=True;";

            // SQL query to fetch product data
            string query = "SELECT ID_Categorias AS ID_Cat, NombreCategoria AS Categoria FROM Categorias";
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
    }
}
