using DocumentFormat.OpenXml.Drawing.Charts;
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
        private string query = "SELECT V.ID_Ventas, V.FechaVenta, V.TotalVenta, " +
            "CONCAT(C.Nombre, ' ',C.Apellido) AS Cliente, E.NombreApellido AS Empleado, P.NombrePromocion AS Promocion " +
            "FROM Ventas V " +
            "JOIN Clientes C ON V.ID_Clientes = C.ID_Clientes " +
            "JOIN Empleados E ON V.ID_Empleados = E.ID_Empleados " +
            "JOIN Promociones P ON V.ID_Promociones = P.ID_Promociones";

        private string query_subtabla = "SELECT " +
            "V.ID_Ventas, " +
            "CONCAT(C.Nombre, ' ', C.Apellido) AS Cliente, " +
            "V.FechaVenta AS Fecha, " +
            "P.NombreProducto AS Producto, " +
            "DV.PrecioUnidad 'Precio Unitario', " +
            "DV.Cantidad, " +
            "DV.SubTotal, " +
            "PR.NombrePromocion AS Promocion, " +
            "PR.Descuento, " +
            "V.TotalVenta AS Total " +
            "FROM Ventas V " +
            "JOIN Clientes C ON V.ID_Clientes = C.ID_Clientes " +
            "JOIN Empleados E ON V.ID_Empleados = E.ID_Empleados " +
            "JOIN DetallesVenta DV ON V.ID_Ventas = DV.ID_Ventas " +
            "JOIN Productos P ON DV.ID_Productos = P.ID_Productos LEFT " +
            "JOIN Promociones PR ON V.ID_Promociones = PR.ID_Promociones ";
        private string[] columnas = { "V.ID_Ventas", "V.FechaVenta", "V.TotalVenta", "CONCAT(C.Nombre, ' ',C.Apellido)", "E.NombreApellido", "P.NombrePromocion" };
        private string[] columnas_subtabla = {
            "V.ID_Ventas",
            "V.FechaVenta", 
            "CONCAT (C.Nombre, ' ' ,C.Apellido)", 
            "P.NombreProducto",
            "DV.PrecioUnidad",
            "DV.Cantidad", 
            "DV.SubTotal",
            "PR.NombrePromocion", 
            "PR.Descuento", 
            "V.TotalVenta" 
        };
        private string idFactura = "";
        public VentanaFacturas()
        {
            InitializeComponent();
            label3.Hide();
            button2.Hide();
            comboBox1.Items.AddRange(new object[] { "ID Ventas", "Fecha", "Total", "Cliente", "Empleado", "Promocion" });
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
            string nwquery = idFactura.Equals("") ? query : query_subtabla;
            int seleccion = comboBox1.SelectedIndex;
            if (textBox1.Text.Length > 0 && seleccion > -1)
            {
                string busqueda = textBox1.Text;
                if (seleccion == 1)
                {
                    busqueda = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                }
                nwquery = DBC.queryBuscar(
                    nwquery, 
                    idFactura.Equals("") ? columnas[seleccion] : columnas_subtabla[seleccion], 
                    busqueda
                    );
                nwquery += idFactura.Equals("") ? "" : " AND V.ID_Ventas = " + idFactura;
            } else
            {
                nwquery += idFactura.Equals("") ? "" : "WHERE V.ID_Ventas = " + idFactura;
            }
            TablaFacturas.DataSource = null;
            TablaFacturas.DataSource = DBC.Data(nwquery);
        }
        private void CargarVenta(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idFactura = TablaFacturas.Rows[e.RowIndex].Cells[0].Value.ToString();
                TablaFacturas.DataSource = DBC.Data(query_subtabla + "WHERE V.ID_Ventas = " + idFactura);
                label3.Show();
                button2.Show();
                dateTimePicker1.Hide();
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(new object[] { 
                    "ID Ventas",
                    "Fecha",
                    "Cliente",
                    "Producto",
                    "Precio Unitario",
                    "Cantidad",
                    "SubTotal",
                    "Promocion",
                    "Descuento", 
                    "Total" 
                });
            }
        }
        private void Volver(object sender, EventArgs e)
        {
            TablaFacturas.DataSource = DBC.Data(query);
            label3.Hide();
            button2.Hide();
            idFactura = "";
            dateTimePicker1.Hide();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] { "ID Ventas", "Fecha", "Total", "Cliente", "Empleado", "Promocion" });
        }
        private void Facturar (object sender, EventArgs e)
        {
            if (idFactura.Equals(""))
            {
                return;
            }
            DBC.factura(idFactura);
        }
    }
}
