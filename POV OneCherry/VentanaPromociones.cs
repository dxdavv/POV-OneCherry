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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace POV_OneCherry
{
    public partial class VentanaPromociones : Form
    {
        private string query = "SELECT ID_Promociones AS ID, FechaPromocion AS Fecha_Termino, NombrePromocion AS Nombre, Descuento FROM Promociones";
        private string[] columnas = { 
            "ID_Promociones", 
            "FechaPromocion", 
            "NombrePromocion", 
            "Descuento" 
        };
        private string IdACambiar = "";
        public VentanaPromociones()
        {
            InitializeComponent();
        }

        private void VentanaPromociones_Load(object sender, EventArgs e)
        {
            TablaPromociones.DataSource = null;
            TablaPromociones.DataSource = DBC.Data(query);
            dateTimePicker2.Hide();
        }

        private void OnChagedIndex(object sender, EventArgs e)
        {
            textBox1.Show();
            dateTimePicker2.Hide();
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Hide();
                dateTimePicker2.Show();
            }
        }

        private void Buscar(object sender, EventArgs e)
        {
            string nwquery = query;
            int seleccion = comboBox1.SelectedIndex;
            if ((textBox1.Text.Length > 0 || seleccion == 1) && seleccion > -1)
            {
                string busqueda = textBox1.Text;
                if (seleccion == 1)
                {
                    busqueda = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
                }
                nwquery = DBC.queryBuscar(query, columnas[seleccion], busqueda);
            }
            TablaPromociones.DataSource = null;
            TablaPromociones.DataSource = DBC.Data(nwquery);
            textBox1.Clear();
        }
        private void Agregar(object sender, EventArgs e)
        {
            string nwquery = $"INSERT INTO Promociones ({columnas[2]}, {columnas[1]}, {columnas[3]}) VALUES ('{textBox2.Text}', '{dateTimePicker1.Value.Date.ToString("yyyy-MM-dd")}', {decimal.Parse(textBox5.Text)})";
            if (textBox2.Text.Length > 0 && textBox5.Text.Length > 0)
            {
                if (DBC.EditData(nwquery) > 0)
                {
                    MessageBox.Show("Agregado Exitosamente!");
                    VentanaPromociones_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el registro.");
                }
            }
        }
        private void MandarAEditar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdACambiar = TablaPromociones.Rows[e.RowIndex].Cells[0].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(TablaPromociones.Rows[e.RowIndex].Cells[1].Value);
                textBox2.Text = TablaPromociones.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox5.Text = TablaPromociones.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        private void Editar(object sender, EventArgs e)
        {
            int seleccion = comboBox1.SelectedIndex;

            if (textBox2.Text.Length > 0 && textBox5.Text.Length > 0)
            {
                string nwquery = "UPDATE Promociones SET " +
                                 $"{columnas[1]} = '{textBox2.Text}', {columnas[2]} = '{dateTimePicker1.Value.Date.ToString("yyyy-MM-dd")}', {columnas[3]} = '{decimal.Parse(textBox5.Text)}'" +
                                 $"WHERE ID_Promociones = {IdACambiar}";

                textBox2.Clear();
                textBox5.Clear();

                if (DBC.EditData(nwquery) > 0)
                {
                    VentanaPromociones_Load(sender, e);
                    MessageBox.Show("Registro actualizado correctamente!");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro.");
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar llenos antes de editar.");
            }
        }
        private void Eliminar(object sender, EventArgs e)
        {
            string nwquery;
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            if (textBox2.Text.Length > 0 && textBox5.Text.Length > 0 && !IdACambiar.Equals(""))
            {
                nwquery = $"DELETE FROM Promociones WHERE ID_Promociones = {IdACambiar}";
                textBox2.Clear();
                comboBox1.SelectedIndex = -1;

                if (DBC.EditData(nwquery) > 0)
                {
                    VentanaPromociones_Load(sender, e);
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
