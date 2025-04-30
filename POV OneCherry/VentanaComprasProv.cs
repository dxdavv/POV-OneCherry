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
            TablaCompras.DataSource = null;
            TablaCompras.DataSource = DBC.Data(query);
            dateTimePicker1.Hide();
        }
        private void OnChagedIndex(object sender, EventArgs e)
        {
            textBox1.Show();
            dateTimePicker1.Hide();
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Hide();
                dateTimePicker1.Show();
            }
        }
        private void Buscar(object sender, EventArgs e)
        {
            string nwquery = query;
            int seleccion = comboBox1.SelectedIndex;
            if ((textBox1.Text.Length > 0 || seleccion == 1) && seleccion > -1)
            {
                string busqueda = textBox1.Text;
                if (seleccion == 1)
                {
                    busqueda = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                }
                nwquery = DBC.queryBuscar(query, columnas[seleccion], busqueda);
            }
            TablaCompras.DataSource = null;
            TablaCompras.DataSource = DBC.Data(nwquery);
            textBox1.Clear();
        }
        private void ToExcel(object sender, EventArgs e)
        {
            DBC.SentToExcel(query, "Compras Proveedor");
        }
    }
}
