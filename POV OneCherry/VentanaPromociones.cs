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
    public partial class VentanaPromociones : Form
    {
        public VentanaPromociones()
        {
            InitializeComponent();
        }

        private void VentanaPromociones_Load(object sender, EventArgs e)
        {

            string nombreSV = "ANG";
            string servidor = nombreSV + "\\SQLEXPRESS";
            string DB = "PruebaPOS";

            string connectionString = "Server=" + servidor + ";Database=" + DB + ";Trusted_Connection=True;";

            // SQL query to fetch product data
            string query = "SELECT ID_Promociones AS ID, FechaPromocion AS Fecha_Termino, NombrePromocion AS Nombre, Descuento FROM Promociones";
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
    }
}
