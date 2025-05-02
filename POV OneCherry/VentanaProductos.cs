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

namespace POV_OneCherry
{
    public partial class VentanaProductos : Form
    {
        private string query = "SELECT Productos.ID_Productos AS ID_Prod, Productos.NombreProducto AS Nombre_Prod, Productos.Precio AS Precio, Productos.Stock AS Stock, Categorias.NombreCategoria AS Categoria FROM Productos " +
                "JOIN Categorias ON Productos.ID_Categorias = Categorias.ID_Categorias";
        private string[] columnas = { "ID_Productos", "NombreProducto", "Precio", "Stock", "NombreCategoria" };
        private string[] filtros = { "ID_Prod", "Nombre_Prod", "Precio", "Stock", "Categoria" };
        private string IdACambiar = "";
        private string[] IdCategorias;
        private string[] categorias;
        public VentanaProductos()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            TablaProductos.DataSource = DBC.Data(query);
            categorias = DBC.GetData("SELECT NombreCategoria FROM Categorias");
            IdCategorias = DBC.GetData("SELECT ID_Categorias FROM Categorias");
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(categorias);
        }
        private void Buscar(object sender, EventArgs e)
        {
            string nwquery = query;
            int seleccion = comboBox1.SelectedIndex;
            if (textBox1.Text.Length > 0 && seleccion > -1)
            {
                nwquery = DBC.queryBuscar(query, columnas[seleccion], textBox1.Text);
            }
            TablaProductos.DataSource = null;
            TablaProductos.DataSource = DBC.Data(nwquery);
            textBox1.Clear();
        }
        private void MandarAEditar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdACambiar = TablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = TablaProductos.Rows[e.RowIndex].Cells[filtros[1]].Value.ToString();
                textBox3.Text = TablaProductos.Rows[e.RowIndex].Cells[filtros[2]].Value.ToString();
                comboBox2.SelectedIndex = Array.IndexOf(categorias, TablaProductos.Rows[e.RowIndex].Cells[filtros[4]].Value.ToString());
                textBox4.Text = TablaProductos.Rows[e.RowIndex].Cells[filtros[3]].Value.ToString();
            }
        }
        private void Agregar(object sender, EventArgs e)
        {
            string nwquery;
            int seleccion = comboBox2.SelectedIndex;
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && seleccion > -1)
            {
                nwquery = $"INSERT INTO Productos ({columnas[1]}, {columnas[2]}, {columnas[3]}, ID_Categorias) " +
                    $"VALUES ('{textBox2.Text}', '{textBox3.Text}', '{0}', '{IdCategorias[seleccion]}')";
                if (DBC.EditData(nwquery) > 0)
                {
                    MessageBox.Show("Agregado Exitosamente");
                }
            }
            Form3_Load(sender, e);
        }
        private void Editar(object sender, EventArgs e)
        {
            string nwquery;
            int seleccion = comboBox2.SelectedIndex;
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && seleccion > -1)
            {
                nwquery = "UPDATE Productos SET " +
                    $"{columnas[1]}='{textBox2.Text}', {columnas[2]}='{textBox3.Text}', {columnas[3]}='{textBox4.Text}', ID_Categorias='{IdCategorias[seleccion]}' WHERE ID_Productos={IdACambiar}";

                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;

                if (DBC.EditData(nwquery) > 0)
                {
                    Form3_Load(sender, e);
                    MessageBox.Show("Registro actualizado correctamente!");
                    return;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro.");
                }
            }
            Form3_Load(sender, e);
        }
        private void Eliminar(object sender, EventArgs e)
        {
            string nwquery;
            int seleccion = comboBox2.SelectedIndex;
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && seleccion > -1 && !IdACambiar.Equals(""))
            {
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                nwquery = $"DELETE FROM Productos WHERE ID_Productos = {IdACambiar}";

                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;

                if (DBC.EditData(nwquery) > 0)
                {
                    Form3_Load(sender, e);
                    MessageBox.Show("Registro eliminado correctamente!");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro.");
                }
            }
        }
        private void onCloseChild(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void botonCategorias(object sender, EventArgs e)
        {
            Form cat = new VentanaCategoría();
            cat.Show();
            this.Hide();
            cat.FormClosed += onCloseChild;
            categorias = DBC.GetData("SELECT NombreCategoria FROM Categorias");
            IdCategorias = DBC.GetData("SELECT ID_Categorias FROM Categorias");
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(categorias);
        }
        private void MandarExcel(object sender, EventArgs e)
        {
            DBC.SentToExcel(query, "Productos");
        }
        private void NoSePuede (object sender, EventArgs e)
        {
            MessageBox.Show("Para aumentar tu stock debes solicitar a proveedor", "No disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
