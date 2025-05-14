using iText.Commons.Actions;

namespace POV_OneCherry
{
    public partial class VentanaComprasProv : Form
    {
        private string[] proveedores;
        private string[] productos;
        private List<string> IdProductos = new List<string>();
        private List<string> IdProveedores = new List<string>();
        private string IdProveedor = "";
        private string IdProducto = "";
        private string IdCompra = "";
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
                IdProductos.Add(IdProducto);
                IdProveedores.Add(IdProveedor);
                string producto = DBC.GetData(
                    "SELECT Productos.NombreProducto " +
                    "FROM Productos " +
                    $"WHERE ID_Productos = '{IdProducto}'")[0];
                string cantidad = numericUpDown1.Value.ToString();
                string precioU = textBox1.Text;
                double subtotal = double.Parse(precioU) * int.Parse(cantidad);
                total += subtotal;
                foreach (DataGridViewRow row in TablaSolicitarCompras.Rows)
                {
                    if (row.Cells[0].Value.ToString() == producto && row.Cells[2].ToString() == precioU)
                    {
                        row.Cells[1].Value = int.Parse(row.Cells[1].Value.ToString() ?? "") + int.Parse(cantidad);
                        row.Cells[3].Value = double.Parse(row.Cells[1].Value.ToString() ?? "") * double.Parse(precioU);
                        return;
                    }
                }
                TablaSolicitarCompras.Rows.Add(producto, cantidad, precioU, subtotal);
                textBox1.Clear();
                numericUpDown1.Value = 1;
                IdProducto = "";
                IdProveedor = "";
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                proveedores = DBC.GetData("SELECT ID_Proveedores FROM Proveedores");
                comboBox1.Items.AddRange(DBC.GetData("SELECT NombreProveedor FROM Proveedores"));
                productos = DBC.GetData("SELECT ID_Productos FROM Productos");
                comboBox2.Items.AddRange(DBC.GetData("SELECT NombreProducto FROM Productos"));
            }
        }

        private void MandarAEliminarProductos(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                total -= double.Parse(TablaSolicitarCompras.Rows[e.RowIndex].Cells[3].Value.ToString());
                IdProductos.Remove(IdProductos[e.RowIndex]);
                IdProveedores.Remove(IdProveedores[e.RowIndex]);
                TablaSolicitarCompras.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void seleccionarProveedor(object sender, EventArgs e)
        {
            IdProveedor = proveedores[comboBox1.SelectedIndex];
            if (comboBox2.SelectedIndex > -1)
            {
                IdProducto = productos[comboBox2.SelectedIndex];
            }
            else
            {
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
        }
        private void seleccionarProducto(object sender, EventArgs e)
        {
            IdProducto = productos[comboBox2.SelectedIndex];
            if (comboBox1.SelectedIndex > -1)
            {
                IdProveedor = proveedores[comboBox1.SelectedIndex];
            }
            else
            {
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
        }

        private void solicitarStock(object sender, EventArgs e)
        {
            if (IdProductos.Count > 0)
            {
                string nwquery = "INSERT INTO ComprasProveedor (FechaCompra, PrecioTotal) " +
                    $"VALUES (GETDATE(), {total})";
                DBC.EditData(nwquery);
                IdCompra = DBC.GetData("SELECT ID_ComprasProveedor FROM ComprasProveedor ORDER BY ID_ComprasProveedor DESC")[0];
                nwquery = "INSERT INTO DetallesCompra (Cantidad, PrecioUnidad, SubTotal, ID_Productos, ID_Proveedores, ID_ComprasProveedor) VALUES ";
                int indice = 0;
                foreach (DataGridViewRow row in TablaSolicitarCompras.Rows)
                {
                    string cantidad = row.Cells[1].Value.ToString();
                    string precioU = row.Cells[2].Value.ToString();
                    string subtotal = row.Cells[3].Value.ToString();
                    nwquery += $"('{cantidad}', '{precioU}', '{subtotal}', '{IdProductos[indice]}', '{IdProveedores[indice]}', '{IdCompra}')";
                    if (indice < IdProductos.Count - 1)
                    {
                        nwquery += ", ";
                    }
                    indice++;
                }
                if (DBC.EditData(nwquery) > 0)
                {
                    MessageBox.Show("Compra realizada");
                    IdProductos.Clear();
                    IdProveedores.Clear();
                    IdProveedor = "";
                    IdProducto = "";
                    IdCompra = "";
                    total = 0;
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    proveedores = DBC.GetData("SELECT ID_Proveedores FROM Proveedores");
                    comboBox1.Items.AddRange(DBC.GetData("SELECT NombreProveedor FROM Proveedores"));
                    productos = DBC.GetData("SELECT ID_Productos FROM Productos");
                    comboBox2.Items.AddRange(DBC.GetData("SELECT NombreProducto FROM Productos"));
                    TablaSolicitarCompras.DataSource = null;
                    TablaSolicitarCompras.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("No hay compras en el carrito");
            }
        }
    }
}
