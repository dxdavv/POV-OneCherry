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
    public partial class VentanaSoporte : Form
    {
        public VentanaSoporte()
        {
            InitializeComponent();
        }
        private void ManualAdmin(object sender, EventArgs e)
        {
            string rutaPDF = Path.Combine(Application.StartupPath, "Resources", "ManualAdmin.pdf");
            DBC.ImprimirPDF(rutaPDF);
        }
    }
}
