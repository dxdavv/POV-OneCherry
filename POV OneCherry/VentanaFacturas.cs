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
        private string query = "SELECT CONCAT (Clientes.Nombre, ' ' ,Clientes.Apellido) AS Nombre_Cliente, Ventas.FechaVenta AS Fecha_Venta, " +
                "Productos.NombreProducto AS Productos, DetallesVenta.Cantidad, DetallesVenta.PrecioUnidad AS P_Unitario, " +
                "Promociones.NombrePromocion, Promociones.Descuento, Ventas.TotalVenta AS Total FROM DetallesVenta " +
                "JOIN Ventas ON DetallesVenta.ID_Ventas = Ventas.ID_Ventas " +
                "JOIN Clientes ON Ventas.ID_Clientes = Clientes.ID_Clientes " +
                "JOIN Promociones ON Ventas.ID_Promociones = Promociones.ID_Promociones " +
                "JOIN Productos ON DetallesVenta.ID_Productos = Productos.ID_Productos";
        private string[] columnas = { "CONCAT (Clientes.Nombre, ' ' ,Clientes.Apellido)", "Ventas.FechaVenta", "Productos.NombreProducto", "DetallesVenta.Cantidad", "DetallesVenta.PrecioUnidad", "Promociones.NombrePromocion", "Promociones.Descuento", "Ventas.TotalVenta" };
        public VentanaFacturas()
        {
            InitializeComponent();
        }
        private void VentanaFacturas_Load(object sender, EventArgs e)
        {
            TablaFacturas.DataSource = DBC.Data(query);
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
            TablaFacturas.DataSource = null;
            TablaFacturas.DataSource = DBC.Data(nwquery);
        }

    }
}
