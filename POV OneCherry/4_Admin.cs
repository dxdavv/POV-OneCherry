namespace POV_OneCherry
{
    public partial class Administrador : Form
    {
        private string query = "";
        private int ventana = 0;
        private string IdACambiar = "";
        private string[] categorias = { }, IdCategorias = { }, columnas = { },
            ventanaActiva = { "Proveedores", "Clientes", "Empleados", "Administrador" },
            IdJoin = { "ID_Productos", "ID_Usuarios" },
            RecuadrosTexto = { };

        public Administrador(string nombre = "default")
        {
            InitializeComponent();
            label4.Text = nombre;
        }
        private void Administrador_Load(object sender, EventArgs e)
        {
            comboBox2.Hide();
            label6.Hide();
            botonEmpleados(sender, e);
        }
        private void onCloseChild(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void MandarAEditar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdACambiar = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "";
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (ventana == 1)
                {
                    return;
                }
                comboBox2.SelectedIndex = Array.IndexOf(categorias, dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
        }
        private void botonProveedores(object sender, EventArgs e)
        {
            ventana = 0;
            RecuadrosTexto = new string[] { "ID", "Nombre", "Email", "Telefono", "Direccion", "Producto" };
            label7.Text = RecuadrosTexto[1];
            label5.Text = RecuadrosTexto[2];
            label8.Text = RecuadrosTexto[3];
            label3.Text = RecuadrosTexto[4];
            label6.Text = RecuadrosTexto[5];
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(RecuadrosTexto);
            categorias = DBC.GetData("SELECT NombreProducto FROM Productos");
            IdCategorias = DBC.GetData("SELECT ID_Productos FROM Productos");
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(categorias);
            comboBox2.Show();
            label6.Show();
            columnas = new string[]{ "Proveedores.ID_Proveedores", "Proveedores.NombreProveedor",
                "Proveedores.Email", "Proveedores.Telefono",
                "Proveedores.Direccion", "Productos.NombreProducto" };
            query = "SELECT Proveedores.ID_Proveedores AS ID, Proveedores.NombreProveedor AS " +
                "Nombre, Proveedores.Email, Proveedores.Telefono, Proveedores.Direccion, " +
                "Productos.NombreProducto AS Producto FROM Proveedores JOIN Productos ON Proveedores.ID_Productos = " +
                "Productos.ID_Productos";
            label1.Text = "PROVEEDORES";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            button12.Show();
            dataGridView1.DataSource = DBC.Data(query);
        }

        private void botonClientes(object sender, EventArgs e)
        {
            ventana = 1;
            RecuadrosTexto = new string[] { "ID", "Nombre", "Apellido", "Email", "Telefono" };
            label7.Text = RecuadrosTexto[1];
            label5.Text = RecuadrosTexto[2];
            label8.Text = RecuadrosTexto[3];
            label3.Text = RecuadrosTexto[4];
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(RecuadrosTexto);
            comboBox2.Items.Clear();
            comboBox2.Hide();
            label6.Hide();
            columnas = new string[]{ "Clientes.ID_Clientes", "Clientes.Nombre", "Clientes.Apellido",
                "Clientes.Email", "Clientes.Telefono" };
            query = "SELECT Clientes.ID_Clientes AS ID, Clientes.Nombre, Clientes.Apellido, " +
                "Clientes.Email, Clientes.Telefono FROM Clientes";
            label1.Text = "CLIENTES";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            button12.Hide();
            dataGridView1.DataSource = DBC.Data(query);
        }
        private void botonEmpleados(object sender, EventArgs e)
        {
            ventana = 2;
            RecuadrosTexto = new string[] { "ID", "Nombre", "Email", "Telefono", "Direccion", "Usuarios" };
            label7.Text = RecuadrosTexto[1];
            label5.Text = RecuadrosTexto[2];
            label8.Text = RecuadrosTexto[3];
            label3.Text = RecuadrosTexto[4];
            label6.Text = RecuadrosTexto[5];
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(RecuadrosTexto);
            string evitarduplicidad = " WHERE ID_Usuarios NOT IN (SELECT ID_Usuarios FROM Empleados) " +
                "AND Tipo = 'Empleado'";
            categorias = DBC.GetData("SELECT NombreUsuario FROM Usuarios" + evitarduplicidad);
            IdCategorias = DBC.GetData("SELECT ID_Usuarios FROM Usuarios" + evitarduplicidad);
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(categorias);
            comboBox2.Show();
            label6.Show();
            columnas = new string[]{ "Empleados.ID_Empleados", "Empleados.NombreApellido",
                "Empleados.Email", "Empleados.Telefono", "Empleados.Direccion",
                "Usuarios.NombreUsuario" };
            query = "SELECT Empleados.ID_Empleados AS ID, Empleados.NombreApellido AS " +
                "Nombre, Empleados.Email, Empleados.Telefono, Empleados.Direccion, " +
                "Usuarios.NombreUsuario FROM Empleados JOIN Usuarios ON Empleados.ID_Usuarios = " +
                "Usuarios.ID_Usuarios";
            label1.Text = "EMPLEADOS";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            button12.Hide();
            dataGridView1.DataSource = DBC.Data(query);
        }
        private void botonAdministradores(object sender, EventArgs e)
        {
            ventana = 3;
            RecuadrosTexto = new string[] { "ID", "Nombre", "Email", "Telefono", "Direccion", "Usuarios" };
            label7.Text = RecuadrosTexto[1];
            label5.Text = RecuadrosTexto[2];
            label8.Text = RecuadrosTexto[3];
            label3.Text = RecuadrosTexto[4];
            label6.Text = RecuadrosTexto[5];
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(RecuadrosTexto);
            string evitarduplicidad = " WHERE ID_Usuarios NOT IN (SELECT ID_Usuarios FROM Administrador) " +
                "AND Tipo = 'Administrador'";
            categorias = DBC.GetData("SELECT NombreUsuario FROM Usuarios" + evitarduplicidad);
            IdCategorias = DBC.GetData("SELECT ID_Usuarios FROM Usuarios" + evitarduplicidad);
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(categorias);
            comboBox2.Show();
            label6.Show();
            columnas = new string[]{ "Administrador.ID_Administrador", "Administrador.NombreApellido",
                "Administrador.Email", "Administrador.Telefono", "Administrador.Direccion",
                "Usuarios.NombreUsuario" };
            query = "SELECT Administrador.ID_Administrador AS ID, Administrador.NombreApellido AS " +
                "Nombre, Administrador.Email, Administrador.Telefono, Administrador.Direccion, " +
                "Usuarios.NombreUsuario FROM Administrador JOIN Usuarios ON Administrador.ID_Usuarios = " +
                "Usuarios.ID_Usuarios";
            label1.Text = "ADMINS";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            button12.Hide();
            dataGridView1.DataSource = DBC.Data(query);
        }
        private void Buscar(object sender, EventArgs e)
        {
            string nwquery = query;
            int seleccion = comboBox1.SelectedIndex;
            if (textBox1.Text.Length > 0 && seleccion > -1)
            {
                nwquery = DBC.queryBuscar(query, columnas[seleccion], textBox1.Text);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBC.Data(nwquery);
            textBox1.Clear();
        }
        private void Agregar(object sender, EventArgs e)
        {
            string nwquery;
            int seleccion = comboBox2.SelectedIndex;
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && textBox5.Text.Length > 0)
            {
                nwquery = $"INSERT INTO {ventanaActiva[ventana]} " +
                    $"({columnas[1]}, {columnas[2]}, {columnas[3]}, {columnas[4]}";
                if (ventana != 1 && seleccion > -1)
                {
                    nwquery += $",{ventanaActiva[ventana]}.{IdJoin[ventana > 0 ? 1 : 0]}" +
                        $") VALUES ('{textBox2.Text}', '{textBox3.Text}', '{textBox5.Text}', '{textBox4.Text}', '{IdCategorias[seleccion]}')";
                }
                else
                {
                    nwquery += $") VALUES ('{textBox2.Text}', '{textBox3.Text}', '{textBox5.Text}', '{textBox4.Text}')";
                }
                if (DBC.EditData(nwquery) > 0)
                {
                    MessageBox.Show("Agregado Exitosamente");
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    categorias = categorias.Where(x => x != categorias[seleccion]).ToArray();
                    IdCategorias = IdCategorias.Where(x => x != IdCategorias[seleccion]).ToArray();
                    comboBox2.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el registro.");
                }
            }
            dataGridView1.DataSource = DBC.Data(query);
        }
        private void Editar(object sender, EventArgs e)
        {
            string nwquery;
            int seleccion = comboBox2.SelectedIndex;
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && textBox4.Text.Length > 0)
            {
                nwquery = $"UPDATE {ventanaActiva[ventana]} SET ";
                if (ventana != 1 && seleccion > -1)
                {
                    nwquery += $"{columnas[1]}='{textBox2.Text}', " +
                        $"{columnas[2]}='{textBox3.Text}', " +
                        $"{columnas[3]}='{textBox5.Text}', " +
                        $"{columnas[4]}='{textBox4.Text}', " +
                        $"{IdJoin[ventana > 0 ? 1 : 0]}='{IdCategorias[seleccion]}' ";

                }
                else
                {
                    nwquery += $"{columnas[1]}='{textBox2.Text}', " +
                        $"{columnas[2]}='{textBox3.Text}', " +
                        $"{columnas[3]}='{textBox5.Text}', " +
                        $"{columnas[4]}='{textBox4.Text}' ";
                }
                nwquery += $"WHERE ID_{ventanaActiva[ventana]}={IdACambiar}";


                if (DBC.EditData(nwquery) > 0)
                {
                    MessageBox.Show("Registro actualizado correctamente!");
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    comboBox2.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro.");
                }
            }
            dataGridView1.DataSource = DBC.Data(query);
        }
        private void Eliminar(object sender, EventArgs e)
        {
            string nwquery;
            int seleccion = comboBox2.SelectedIndex;
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 || seleccion > -1 && !IdACambiar.Equals(""))
            {
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                nwquery = $"DELETE FROM {ventanaActiva[ventana]} WHERE ID_{ventanaActiva[ventana]} = {IdACambiar}";

                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                comboBox1.SelectedIndex = -1;

                if (DBC.EditData(nwquery) > 0)
                {
                    MessageBox.Show("Registro eliminado correctamente!");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro.");
                }
            }
            dataGridView1.DataSource = DBC.Data(query);
        }
        private void botonProductos(object sender, EventArgs e)
        {
            Form productos = new VentanaProductos();
            productos.Show();
            this.Hide();
            productos.FormClosed += onCloseChild;
        }

        private void botonVenta(object sender, EventArgs e)
        {
            Form venta = new VentanaVenta();
            venta.Show();
            this.Hide();
            venta.FormClosed += onCloseChild;
        }

        private void botonUsuarios(object sender, EventArgs e)
        {
            Form usuarios = new Usuarios();
            usuarios.Show();
            this.Hide();
            usuarios.FormClosed += onCloseChild;
        }

        private void botonPromociones(object sender, EventArgs e)
        {
            Form promociones = new VentanaPromociones();
            promociones.Show();
            this.Hide();
            promociones.FormClosed += onCloseChild;
        }

        private void botonSoporte(object sender, EventArgs e)
        {
            Form soporte = new VentanaSoporte();
            soporte.Show();
            this.Hide();
            soporte.FormClosed += onCloseChild;
        }

        private void botonComprasProveedor(object sender, EventArgs e)
        {
            Form compras = new VentanaComprasProv();
            compras.Show();
            this.Hide();
            compras.FormClosed += onCloseChild;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DBC.Salir();
        }
    }
}
