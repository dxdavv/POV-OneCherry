using DocumentFormat.OpenXml.Wordprocessing;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace POV_OneCherry
{
    public partial class Usuarios : Form
    {
        private string query = "SELECT * FROM Usuarios";
        private string[] columnas = { "NombreUsuario" , "Pin" , "Tipo" };
        private string[] tipos = { "Administrador", "Empleado" };
        private string IdACambiar = "";

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            TablaUsuarios.DataSource = null;
            TablaUsuarios.DataSource = DBC.Data(query);
        }
        private void Buscar(object sender, EventArgs e)
        {
            string nwquery = query;
            int seleccion = comboBox2.SelectedIndex;
            string ordenamiento = seleccion > 0 ? columnas[seleccion] : columnas[0];
            nwquery += $" ORDER BY {ordenamiento}";
            TablaUsuarios.DataSource = null;
            TablaUsuarios.DataSource = DBC.Data(nwquery);
        }
        private void Agregar(object sender, EventArgs e)
        {
            string nwquery;
            int seleccion = comboBox1.SelectedIndex;
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && seleccion > -1)
            {
                nwquery = "INSERT INTO Usuarios (NombreUsuario, Pin, Tipo) " +
                    $"VALUES ('{textBox2.Text}', {textBox3.Text}, '{tipos[seleccion]}')";
                if (DBC.EditData(nwquery) > 0)
                {
                    MessageBox.Show("Agregado Exitosamente");
                }
            }
            Usuarios_Load(sender, e);
        }
        private void MandarAEditar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdACambiar = TablaUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = TablaUsuarios.Rows[e.RowIndex].Cells[columnas[0]].Value.ToString();
                textBox3.Text = TablaUsuarios.Rows[e.RowIndex].Cells[columnas[1]].Value.ToString();
                comboBox1.SelectedIndex = Array.IndexOf(tipos, TablaUsuarios.Rows[e.RowIndex].Cells[columnas[2]].Value.ToString());

            }
        }
        private void Editar (object sender, EventArgs e)
        {
            int seleccion = comboBox1.SelectedIndex;
            string nwquery;
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && seleccion > -1)
            {
                nwquery = "UPDATE Usuarios SET " +
                    $"{columnas[0]}='{textBox2.Text}', {columnas[1]}={textBox3.Text}, {columnas[2]}='{tipos[seleccion]}' WHERE ID_Usuarios = {IdACambiar}";
                
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;

                if (DBC.EditData(nwquery) > 0)
                {
                    Usuarios_Load(sender, e);
                    MessageBox.Show("Registro actualizado correctamente!");
                    return;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro.");
                }
            }
            Usuarios_Load (sender, e);
        }
        private void Eliminar(object sender, EventArgs e)
        {
            int seleccion = comboBox1.SelectedIndex;
            string nwquery;
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && seleccion > -1 && !IdACambiar.Equals(""))
            {
                nwquery = $"DELETE FROM Usuarios WHERE ID_Usuarios = {IdACambiar}";

                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;

                if (DBC.EditData(nwquery) > 0)
                {
                    Usuarios_Load(sender, e);
                    MessageBox.Show("Registro eliminado correctamente!");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro.");
                }
            }
        }
    }
}
