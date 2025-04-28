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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace POV_OneCherry
{
    public partial class Empleado : Form
    {
        private string queryClientes = "SELECT * FROM Clientes";
        private string queryProductos = "SELECT Productos.ID_Productos AS ID_Prod, Productos.NombreProducto AS Nombre_Prod, Productos.Precio AS Precio, Productos.Stock AS Stock, Categorias.NombreCategoria AS Categoria FROM Productos " +
                    "JOIN Categorias ON Productos.ID_Categorias = Categorias.ID_Categorias";
        private string[] columnasClientes = { "ID_Clientes", "Nombre", "Apellido", "Email", "Telefono" };
        private string[] columnasProductos = { "Productos.ID_Productos", "Productos.NombreProducto", "Productos.Precio", "Productos.Stock", "Categorias.NombreCategoria" };
        private string[] filtrosClientes = { "ID", "Nombre", "Precio", "Stock", "Categoría" };
        private string[] filtrosProductos = { "ID", "Nombre", "Apellido","Email", "Teléfono" };
        private string IdCliente = "";
        private string IdProducto = "";
        private string IdVenta = "";
        private List<string> IdProductos = new List<string>();
        private List<string> IdVentas = new List<string>();
        private string user;
        // producto, precio, cantidad, subtotal
        public Empleado(string user = "default")
        {
            this.user = user;
            InitializeComponent();
        }

        private void botonAgregarCliente(object sender, EventArgs e)
        {
            Form agregar = new RegistroCliente();
            agregar.ShowDialog();
            Form3_Load(sender, e);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label4.Text = user;
            TablaProducto.DataSource = DBC.Data(queryProductos);
            TablaClientes.DataSource = DBC.Data(queryClientes);
        }
        private void MandarAAgregarClientes(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdCliente = TablaClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        private void MandarAAgregarProductos(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdProducto = TablaProducto.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        private void BuscarClientes(object sender, EventArgs e)
        {
            string nwquery = queryClientes;
            int seleccion = comboBox2.SelectedIndex;
            string ordenamiento = seleccion > 0 ? filtrosClientes[seleccion] : filtrosClientes[0];
            if (textBox1.Text.Length > 0)
            {
                string busqueda = textBox1.Text;
                nwquery += $" WHERE {columnasClientes[1]} LIKE ('{busqueda}') OR " +
                    $"{columnasClientes[2]} LIKE ('{busqueda}') OR " +
                    $"{columnasClientes[3]} LIKE ('{busqueda}') OR " +
                    $"{columnasClientes[4]} LIKE ('{busqueda}')";
            }
            nwquery += $" ORDER BY {ordenamiento}";
                TablaProducto.DataSource = null;
                TablaProducto.DataSource = DBC.Data(nwquery);
        }
        private void BuscarProductos(object sender, EventArgs e)
        {
            string nwquery = queryProductos;
            int seleccion = comboBox1.SelectedIndex;
            string ordenamiento = seleccion > 0 ? filtrosProductos[seleccion] : filtrosProductos[0];
            if (textBox2.Text.Length > 0)
            {
                string busqueda = textBox1.Text;
                nwquery += $" WHERE {columnasProductos[1]} LIKE ('{busqueda}') OR " +
                    $"{columnasProductos[2]} LIKE ('{busqueda}') OR " +
                    $"{columnasProductos[3]} LIKE ('{busqueda}') OR " +
                    $"{columnasProductos[4]} LIKE ('{busqueda}')";
            }
            nwquery += $" ORDER BY {ordenamiento}";
            TablaProducto.DataSource = null;
            TablaProducto.DataSource = DBC.Data(nwquery);
        }
        private void AgregarClienteVenta (object sender, EventArgs e)
        {
            if (IdCliente.Equals(""))
            {
                return;
            }
            label21.Text = DBC.GetData("SELECT CONCAT(Nombre, ' ', Apellido) AS Nombre FROM Clientes")[0];

        }
        private void AgregarProductoVenta (object sender, EventArgs e)
        {
            if (IdProducto.Length > 0 && IdCliente.Length > 0)
            {
                IdProductos.Add(IdProducto);
                string cantidad = numericUpDown1.Value.ToString();
                string precioU = DBC.GetData($"SELECT Precio FROM Productos WHERE ID_Productos = {IdProductos}")[0];
                double subtotal = double.Parse(precioU) * int.Parse(cantidad);
                string nwquery = "INSERT INTO DetallesVenta (Cantidad, PrecioUnidad, SubTotal, ID_Productos) " +
                    $"VALUES ('{cantidad}', '{precioU}', '{subtotal}', '{IdProducto}')";
                if (DBC.EditData(nwquery) > 0)
                {
                    // ACTUALIZAR TABLA CARRITO Y ANUNCIARLO
                    string id = DBC.GetData("SELECT @@IDENTITY AS LastInsertedID")[0];
                    IdVentas.Add(id);
                    string ids = "(";
                    foreach (string i in IdVentas) {
                        ids += i + ",";
                    }
                    ids += IdVentas[-1] + ")";
                    TablaVenta.DataSource = DBC.Data($"SELECT * FROM DetalleVenta WHERE ID_Detalle in {ids}");
                }
            }
        }
    }
}
