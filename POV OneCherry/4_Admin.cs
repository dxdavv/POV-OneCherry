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
        private void onCloseChild(object? sender, FormClosedEventArgs e)
        {
            this.Show();
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
    }
}
