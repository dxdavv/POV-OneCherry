using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POV_OneCherry
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ButtonProveedor_Click(object sender, EventArgs e)
        {

        }

        private void Productos_Click(object sender, EventArgs e)
        {
            //this.SendToBack();
            new VentanaProductos().ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new VentanaSoporte().ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonVenta(object sender, EventArgs e)
        {
            Form venta = new VentanaVenta();
            venta.Show();
            this.Hide();
            venta.FormClosed += onCloseChild;
        }
        private void onCloseChild(object? sender, FormClosedEventArgs e)
        {
            this.Show();
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
    }
}
