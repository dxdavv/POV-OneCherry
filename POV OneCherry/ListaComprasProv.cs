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
    public partial class ListaComprasProv : Form
    {
        private string query = "SELECT ComprasProveedor.ID_ComprasProveedor AS ID_Compra, ComprasProveedor.FechaCompra AS Fecha_Compra, " +
                "Proveedores.NombreProveedor AS Proveedor, Productos.NombreProducto AS Productos, DetallesCompra.Cantidad, " +
                "DetallesCompra.PrecioUnidad AS P_Unitario, ComprasProveedor.PrecioTotal AS P_Total FROM DetallesCompra " +
                "JOIN Productos ON DetallesCompra.ID_Productos = Productos.ID_Productos " +
                "JOIN ComprasProveedor ON DetallesCompra.ID_ComprasProveedor = ComprasProveedor.ID_ComprasProveedor " +
                "JOIN Proveedores ON ComprasProveedor.ID_Proveedores = Proveedores.ID_Proveedores";
        private string[] columnas = { "ComprasProveedor.ID_ComprasProveedor", "ComprasProveedor.FechaCompra", "Proveedores.NombreProveedor", "Productos.NombreProducto", "DetallesCompra.Cantidad", "DetallesCompra.PrecioUnidad", "ComprasProveedor.PrecioTotal" };

        public ListaComprasProv()
        {
            InitializeComponent();
        }

        private void ListaComprasProv_Load(object sender, EventArgs e)
        {
            TablaListaCompras.DataSource = null;
            TablaListaCompras.DataSource = DBC.Data(query);
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
            TablaListaCompras.DataSource = null;
            TablaListaCompras.DataSource = DBC.Data(nwquery);
            textBox1.Clear();
        }
        private void ToExcel(object sender, EventArgs e)
        {
            DBC.SentToExcel(query);
        }
    }
}
