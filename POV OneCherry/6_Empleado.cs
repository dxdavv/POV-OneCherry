﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Numerics;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace POV_OneCherry
{
    public partial class Empleado : Form
    {
        private string queryClientes = "SELECT * FROM Clientes";
        private string queryProductos = "SELECT Productos.ID_Productos AS ID_Prod, Productos.NombreProducto AS Nombre_Prod, Productos.Precio AS Precio, Productos.Stock AS Stock, Categorias.NombreCategoria AS Categoria FROM Productos " +
                    "JOIN Categorias ON Productos.ID_Categorias = Categorias.ID_Categorias";
        private string[] columnasClientes = { "ID_Clientes", "Nombre", "Apellido", "Email", "Telefono" };
        private string[] columnasProductos = { "Productos.ID_Productos", "Productos.NombreProducto", "Productos.Precio", "Productos.Stock", "Categorias.NombreCategoria" };
        private string[] IdPromociones;
        private string[] promociones;
        private string[] descuentos;
        private string IdEmpleado = "";
        private string IdCliente = "";
        private string IdProducto = "";
        private string IdVenta = "";
        private List<string> IdProductos = new List<string>();
        double total;
        // producto, precio, cantidad, subtotal
        public Empleado(string user = "default", string IdEmpleado = "2")
        {
            this.IdEmpleado = IdEmpleado;
            //this.IdEmpleado = 2.ToString();
            InitializeComponent();
            label4.Text = user;
            IdPromociones = DBC.GetData("SELECT ID_Promociones FROM Promociones");
            promociones = DBC.GetData("SELECT NombrePromocion FROM Promociones");
            descuentos = DBC.GetData("SELECT Descuento FROM Promociones");
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(promociones);
        }

        private void botonAgregarCliente(object sender, EventArgs e)
        {
            Form agregar = new RegistroCliente();
            agregar.ShowDialog();
            Form3_Load(sender, e);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            TablaProducto.DataSource = DBC.Data(queryProductos);
            TablaClientes.DataSource = DBC.Data(queryClientes);
        }
        private void MandarAAgregarClientes(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdCliente = TablaClientes.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "";
            }
        }
        private void MandarAAgregarProductos(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdProducto = TablaProducto.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "";
            }
        }
        private void MandarAEliminarProductos(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                total -= double.Parse(TablaVenta.Rows[e.RowIndex].Cells[3].Value.ToString() ?? "");
                IdProductos.Remove(IdProductos[e.RowIndex]);
                TablaVenta.Rows.RemoveAt(e.RowIndex);
                textBox5.Text = total.ToString("0.00");
            }
        }

        private void onPromoSelected(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex != -1)
            {
                textBox5.Text = (total - double.Parse(descuentos[comboBox4.SelectedIndex])).ToString("0.00");
            }
            else
            {
                textBox5.Text = total.ToString("0.00");
            }
        }

        private void Cancelar(object sender, EventArgs e)
        {
            if (IdVenta.Equals(""))
            {
                return;
            }
            DBC.EditData("DELETE FROM Ventas WHERE ID_Ventas = " + IdVenta);
            IdCliente = "";
            IdProducto = "";
            IdVenta = "";
            IdProductos = new List<string>();
            total = 0;
            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox9.Clear();
            label21.Text = "";
            comboBox4.SelectedIndex = -1;
            TablaVenta.DataSource = null;
        }
        private void BuscarClientes(object sender, EventArgs e)
        {
            int seleccion = comboBox2.SelectedIndex;
            if (textBox1.Text.Length > 0 && seleccion > -1)
            {
                TablaClientes.DataSource = null;
                TablaClientes.DataSource = DBC.Data(
                    DBC.queryBuscar(
                        queryClientes,
                        columnasClientes[seleccion],
                        textBox1.Text
                        )
                    );
            }
            TablaClientes.DataSource = null;
            TablaClientes.DataSource = DBC.Data(queryClientes);
        }
        private void BuscarProductos(object sender, EventArgs e)
        {
            int seleccion = comboBox1.SelectedIndex;
            if (textBox2.Text.Length > 0 && seleccion > -1)
            {
                TablaProducto.DataSource = null;
                TablaProducto.DataSource = DBC.Data(
                    DBC.queryBuscar(
                        queryProductos,
                        columnasProductos[seleccion],
                        textBox2.Text
                        )
                    );
            }
            else
            {
                TablaProducto.DataSource = null;
                TablaProducto.DataSource = DBC.Data(queryProductos);
            }
        }
        private void AgregarClienteVenta(object sender, EventArgs e)
        {
            if (IdCliente.Equals(""))
            {
                return;
            }
            string nwquery = $"SELECT CONCAT(Nombre, ' ', Apellido) AS Nombre FROM Clientes WHERE ID_Clientes = {IdCliente}";
            label21.Text = DBC.GetData(nwquery)[0];
        }

        private void AgregarProductoVenta(object sender, EventArgs e)
        {
            if (IdProducto.Length > 0 && IdCliente.Length > 0 && numericUpDown1.Value > 0)
            {
                if (numericUpDown1.Value > decimal.Parse(DBC.GetData($"SELECT Stock FROM Productos WHERE ID_Productos = {IdProducto}")[0]))
                {
                    MessageBox.Show("No hay suficiente stock");
                    return;
                }
                IdProductos.Add(IdProducto);
                string nombre = DBC.GetData($"SELECT NombreProducto FROM Productos WHERE ID_Productos = {IdProducto}")[0];
                string cantidad = numericUpDown1.Value.ToString();
                string precioU = DBC.GetData($"SELECT Precio FROM Productos WHERE ID_Productos = {IdProducto}")[0];
                double subtotal = double.Parse(precioU) * int.Parse(cantidad);
                total += subtotal;
                foreach (DataGridViewRow row in TablaVenta.Rows)
                {
                    if (row.Cells[0].Value.ToString() == nombre)
                    {
                        int cantidadActual = int.Parse(row.Cells[1].Value.ToString() ?? "") + int.Parse(cantidad);
                        if (cantidadActual > int.Parse(DBC.GetData($"SELECT Stock FROM Productos WHERE ID_Productos = {IdProducto}")[0]))
                        {
                            MessageBox.Show("No hay suficiente stock");
                            return;
                        }
                        row.Cells[1].Value = cantidadActual.ToString();
                        row.Cells[3].Value = (double.Parse(precioU) * cantidadActual).ToString("0.00");
                        textBox5.Text = total.ToString("0.00");
                        return;
                    }
                }
                TablaVenta.Rows.Add(nombre, cantidad, precioU, subtotal);
                textBox5.Text = total.ToString("0.00");
            }
        }
        private void Cambio(object sender, EventArgs e)
        {
            if (textBox5.Text.Length < 1 || textBox6.Text.Length < 1 || comboBox4.SelectedIndex == -1)
            {
                return;
            }
            if (double.Parse(textBox6.Text) < total - double.Parse(descuentos[comboBox4.SelectedIndex]))
            {
                MessageBox.Show("Cantidad a pagar mayor al dinero ingresado");
                return;
            }
            else
            {
                textBox9.Text = (double.Parse(textBox6.Text) - (total - double.Parse(descuentos[comboBox4.SelectedIndex]))).ToString("0.00");
            }
        }
        private void FinalizarVenta(object sender, EventArgs e)
        {
            if (textBox9.Text.Length < 1)
            {
                return;
            }
            double descuento = double.Parse(descuentos[comboBox4.SelectedIndex]);
            string nwventa = "INSERT INTO Ventas (FechaVenta, TotalVenta, ID_Clientes, ID_Empleados, ID_Promociones) " +
                        $"VALUES (GETDATE(), {total - descuento}, '{IdCliente}', '{IdEmpleado}', '{IdPromociones[comboBox4.SelectedIndex]}')";
            DBC.EditData(nwventa);
            IdVenta = DBC.GetData("SELECT ID_Ventas FROM Ventas ORDER BY ID_Ventas DESC")[0];
            string nwquery = $"INSERT INTO DetallesVenta (Cantidad, PrecioUnidad, Subtotal, ID_Productos, ID_Ventas) VALUES ";
            int indice = 0;
            foreach (DataGridViewRow row in TablaVenta.Rows)
            {
                string cantidad = row.Cells[1].Value.ToString();
                string precioU = row.Cells[2].Value.ToString();
                string subtotal = row.Cells[3].Value.ToString();
                string idProducto = IdProductos[indice];
                nwquery += $"({cantidad}, {precioU}, {subtotal}, {idProducto}, {IdVenta}), ";
                indice++;
                if (indice == TablaVenta.Rows.Count)
                {
                    nwquery = nwquery.Remove(nwquery.Length - 2, 2);
                }

            }
            if (DBC.EditData(nwquery) > 0)
            {
                DialogResult resultado = BotonTicketFactura();
                if (resultado == DialogResult.OK)
                {
                    DBC.ImprimirTicket(IdVenta);
                }
                else if (resultado == DialogResult.Cancel)
                {
                    DBC.factura(IdVenta);
                }

                IdVenta = "";
                IdCliente = "";
                IdProducto = "";
                IdProductos = new List<string>();
                total = 0;
                textBox5.Clear();
                textBox6.Clear();
                textBox9.Clear();
                TablaVenta.Rows.Clear();
                TablaVenta.DataSource = null;
                label21.Text = "";
                comboBox4.SelectedIndex = -1;
                TablaProducto.DataSource = DBC.Data(queryProductos);
                TablaClientes.DataSource = DBC.Data(queryClientes);

            }
            else
            {
                MessageBox.Show("Ocurrio un error durante la venta");
            }
        }

        private DialogResult BotonTicketFactura()
        {
            Form mensaje = new Form();
            mensaje.Text = "Seleccion comprobante";
            mensaje.Size = new Size(300, 150);

            Button btnTicket = new Button();
            btnTicket.Text = "Ticket";
            btnTicket.Location = new Point(50, 50);
            btnTicket.DialogResult = DialogResult.OK;
            mensaje.Controls.Add(btnTicket);

            Button btnFactura = new Button();
            btnFactura.Text = "Factura";
            btnFactura.Location = new Point(150, 50);
            btnFactura.DialogResult = DialogResult.Cancel;
            mensaje.Controls.Add(btnFactura);

            mensaje.AcceptButton = btnTicket;
            mensaje.CancelButton = btnFactura;
            return mensaje.ShowDialog();
        }

        private void ManualEmpleado(object sender, EventArgs e)
        {
            string rutaPDF = Path.Combine(Application.StartupPath, "Resources", "ManualEmpleado.pdf");
            DBC.ImprimirPDF(rutaPDF);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            DBC.Salir();
        }
    }
}
