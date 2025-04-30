using ClosedXML.Excel;
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

namespace POV_OneCherry
{
    public partial class VentanaComprasProv : Form
    {
        public VentanaComprasProv()
        {
            InitializeComponent();
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

    }
}
