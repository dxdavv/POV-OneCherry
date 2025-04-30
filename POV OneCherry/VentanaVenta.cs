using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        private string query = "SELECT Ventas.ID_Ventas AS ID_Venta, Empleados.NombreApellido AS Empleado, Ventas.FechaVenta AS Fecha, " +
                "CONCAT (Clientes.Nombre, ' ' ,Clientes.Apellido) AS Nombre_Cliente, Ventas.TotalVenta AS Total, Promociones.NombrePromocion FROM Ventas " +
                "JOIN Clientes ON Ventas.ID_Clientes = Clientes.ID_Clientes  " +
                "JOIN Promociones ON Ventas.ID_Promociones = Promociones.ID_Promociones " +
                "JOIN Empleados ON Ventas.ID_Empleados = Empleados.ID_Empleados";
        private string[] columnas = { 
            "Ventas.ID_Ventas", 
            "Empleados.NombreApellido", 
            "Ventas.FechaVenta",
            "Ventas.TotalVenta",
            "CONCAT (Clientes.Nombre, ' ' ,Clientes.Apellido)", 
            "Promociones.NombrePromocion",
        };
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
            dataGridView1.DataSource = null; 
            dataGridView1.DataSource = DBC.Data(query);
            dateTimePicker1.Hide();
        }
        private void OnChangeSelected(object sender, EventArgs e)
        {
            textBox1.Show();
            dateTimePicker1.Hide();
            if (comboBox1.SelectedIndex == 2)
            {
                dateTimePicker1.Show();
                textBox1.Hide();
            }
        }
        private void Buscar(object sender, EventArgs e)
        {
            string nwquery = query;
            int seleccion = comboBox1.SelectedIndex;
            if ((textBox1.Text.Length > 0 || seleccion == 2) && seleccion > -1)
            {
                string dato = textBox1.Text;
                if (seleccion == 2)
                {
                    dato = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                }
                nwquery = DBC.queryBuscar(query, columnas[seleccion], dato);
                textBox1.Clear();
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBC.Data(query);
        }
        private void ToExcel (object sender, EventArgs e)
        {
            DBC.SentToExcel(query, "Venta");
        }
    }
}
