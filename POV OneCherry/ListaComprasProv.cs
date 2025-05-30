﻿using ClosedXML.Excel;
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
                "ComprasProveedor.PrecioTotal, Proveedores.NombreProveedor AS Proveedor, Productos.NombreProducto AS Productos, DetallesCompra.Cantidad, " +
                "DetallesCompra.PrecioUnidad AS P_Unitario, ComprasProveedor.PrecioTotal AS P_Total FROM DetallesCompra " +
                "JOIN Productos ON DetallesCompra.ID_Productos = Productos.ID_Productos " +
                "JOIN ComprasProveedor ON DetallesCompra.ID_ComprasProveedor = ComprasProveedor.ID_ComprasProveedor " +
                "JOIN Proveedores ON DetallesCompra.ID_Proveedores = Proveedores.ID_Proveedores";
        private string[] columnas = { "ComprasProveedor.ID_ComprasProveedor", "ComprasProveedor.FechaCompra", "Proveedores.NombreProveedor", "Productos.NombreProducto", "DetallesCompra.Cantidad", "DetallesCompra.PrecioUnidad", "ComprasProveedor.PrecioTotal" };
        private string[] filtros = { "ID_Compra", "Fecha_Compra", "Proveedor", "Productos", "Cantidad", "PrecioUnitario", "PrecioTotal" };
        public ListaComprasProv()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(filtros);
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
            if (textBox1.Text.Length > 0 && seleccion > -1)
            {
                nwquery = DBC.queryBuscar(nwquery, columnas[seleccion], textBox1.Text);
            }
            TablaListaCompras.DataSource = null;
            TablaListaCompras.DataSource = DBC.Data(nwquery);
            textBox1.Clear();
        }
        private void ToExcel(object sender, EventArgs e)
        {
            DBC.SentToExcel(query, "Lista de compras a proveedor");
        }
    }
}
