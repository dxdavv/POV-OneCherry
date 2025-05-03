using iText.Commons.Actions;

namespace POV_OneCherry
{
    public partial class VentanaComprasProv : Form
    {
        private string[] proveedores;
        private string[] productos;
        private string IdProveedor = "";
        private string IdProducto = "";
        private string IdCompra = "";
        private string IdEliminar = "";
        private List<string> IdCompras = new List<string>();
        //private List<string> IdCompras = new List<string>();
        private double total = 0;
        public VentanaComprasProv()
        {
            InitializeComponent();
            proveedores = DBC.GetData("SELECT ID_Proveedores FROM Proveedores");
            comboBox1.Items.AddRange(DBC.GetData("SELECT NombreProveedor FROM Proveedores"));
            productos = DBC.GetData("SELECT ID_Productos FROM Productos");
            comboBox2.Items.AddRange(DBC.GetData("SELECT NombreProducto FROM Productos"));
        }

        private void onCloseChild(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void botonListaCompras(object sender, EventArgs e)
        {

            Form lista = new ListaComprasProv();
            lista.Show();
            this.Hide();
            lista.FormClosed += onCloseChild;
        }

        private void AgregarProductoCompra(object sender, EventArgs e)
        {
            if (IdProducto.Length > 0 && IdProveedor.Length > 0 && numericUpDown1.Value > 0 && textBox1.Text.Length > 0)
            {
                if (IdCompra.Equals(""))
                {
                    string nwventa = "INSERT INTO ComprasProveedor (FechaCompra, PrecioTotal) " +
                        $"VALUES (GETDATE(), 0.00)";
                    if (DBC.EditData(nwventa) > 1)
                    {
                        MessageBox.Show("error");
                    }
                    IdCompra = DBC.GetData("SELECT ID_ComprasProveedor FROM ComprasProveedor ORDER BY ID_ComprasProveedor DESC")[0];
                    total = 0;
                }
                string cantidad = numericUpDown1.Value.ToString();
                string precioU = textBox1.Text;
                double subtotal = double.Parse(precioU) * int.Parse(cantidad);
                total += subtotal;
                string nwquery = "INSERT INTO DetallesCompra (Cantidad, PrecioUnidad, SubTotal, ID_Productos, ID_Proveedores, ID_ComprasProveedor) " +
                    $"VALUES ('{cantidad}', '{precioU}', '{subtotal}', '{IdProducto}', '{IdProveedor}', '{IdCompra}')";
                if (DBC.EditData(nwquery) > 0)
                {
                    // ACTUALIZAR TABLA CARRITO Y ANUNCIARLO
                    ActualizarTabla();
                }
            }
        }

        private void MandarAEliminarProductos(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 1)
            //{
            //    TablaSolicitarCompras.DataSource = null;
            //    IdCompra = "";
            //}
            if (e.RowIndex >= 0)
            {
                IdEliminar = IdCompras[e.RowIndex];
                DBC.EditData($"DELETE FROM DetallesCompra WHERE ID_DetallesCompra = {IdEliminar}");
                IdCompras.Remove(IdEliminar);
                ActualizarTabla();
            }
        }
        private void seleccionarProveedor(object sender, EventArgs e)
        {
            IdProveedor = proveedores[comboBox1.SelectedIndex];
            comboBox2.Items.Clear();
            productos = DBC.GetData(
                "SELECT Productos.ID_Productos " +
                "FROM Proveedores " +
                "JOIN Productos " +
                "ON Proveedores.ID_Productos = Productos.ID_Productos " +
                $"WHERE Proveedores.ID_Proveedores = '{IdProveedor}'");
            comboBox2.Items.AddRange(
                DBC.GetData(
                    "SELECT Productos.NombreProducto " +
                    "FROM Proveedores " +
                    "JOIN Productos " +
                    "ON Proveedores.ID_Productos = Productos.ID_Productos " +
                    $"WHERE Proveedores.ID_Proveedores = '{IdProveedor}'"
                    )
                );
        }
        private void seleccionarProducto(object sender, EventArgs e)
        {
            IdProducto = productos[comboBox2.SelectedIndex];
            string selected = comboBox1.SelectedText;
            comboBox1.Items.Clear();
            proveedores = DBC.GetData(
                "SELECT Proveedores.ID_Proveedores " +
                "FROM Proveedores " +
                "JOIN Productos " +
                "ON Proveedores.ID_Productos = Productos.ID_Productos " +
                $"WHERE Productos.ID_Productos = '{IdProducto}'");
            comboBox1.Items.AddRange(
                DBC.GetData(
                "SELECT Proveedores.NombreProveedor " +
                "FROM Proveedores " +
                "JOIN Productos " +
                "ON Proveedores.ID_Productos = Productos.ID_Productos " +
                $"WHERE Productos.ID_Productos = '{IdProducto}'"
                    )
                );
        }
        private void ActualizarTabla()
        {
            string ids = "";
            IdCompras.Add(DBC.GetData("SELECT ID_DetallesCompra FROM DetallesCompra ORDER BY ID_DetallesCompra DESC")[0]);
            foreach (string i in IdCompras)
            {
                if (IdCompras.IndexOf(i) == 0)
                {
                    ids += i;
                }
                else
                {
                    ids += ", " + i;
                }
            }
            string datosTabla = "SELECT Productos.NombreProducto AS Producto, " +
                "DetallesCompra.Cantidad, DetallesCompra.PrecioUnidad AS Precio, " +
                "DetallesCompra.SubTotal FROM DetallesCompra " +
                "JOIN Productos ON DetallesCompra.ID_Productos = Productos.ID_Productos " +
                "JOIN Proveedores ON DetallesCompra.ID_Proveedores = Proveedores.ID_Proveedores " +
                $"WHERE DetallesCompra.ID_DetallesCompra IN({ids})";

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            proveedores = DBC.GetData("SELECT ID_Proveedores FROM Proveedores");
            comboBox1.Items.AddRange(DBC.GetData("SELECT NombreProveedor FROM Proveedores"));
            productos = DBC.GetData("SELECT ID_Productos FROM Productos");
            comboBox2.Items.AddRange(DBC.GetData("SELECT NombreProducto FROM Productos"));
            TablaSolicitarCompras.DataSource = DBC.Data(datosTabla);
        }
        private void solicitarStock(object sender, EventArgs e)
        {
            if (IdCompra.Length > 0 && IdCompras.Count > 0)
            {
                string nwquery = "UPDATE ComprasProveedor SET PrecioTotal = " +
                    $"{total} WHERE ID_ComprasProveedor = {IdCompra}";
                if (DBC.EditData(nwquery) > 0)
                {
                    MessageBox.Show("Compra realizada");
                    IdProveedor = "";
                    IdProducto = "";
                    IdCompra = "";
                    IdCompras.Clear();
                    total = 0;
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    proveedores = DBC.GetData("SELECT ID_Proveedores FROM Proveedores");
                    comboBox1.Items.AddRange(DBC.GetData("SELECT NombreProveedor FROM Proveedores"));
                    productos = DBC.GetData("SELECT ID_Productos FROM Productos");
                    comboBox2.Items.AddRange(DBC.GetData("SELECT NombreProducto FROM Productos"));
                    TablaSolicitarCompras.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("No hay compras en el carrito");
            }
        }
    }
}
