using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricas
{
    public partial class frmFiguras : Form
    {
        public frmFiguras()
        {
            InitializeComponent();
        }

        private void frmFiguras_Load(object sender, EventArgs e)
        {

        }

        private void btnFB_Click(object sender, EventArgs e)
        {
            frmFigurasBidimensionales frmfigurasBidimensionales = new frmFigurasBidimensionales();
            frmfigurasBidimensionales.ShowDialog();
        }

        private void btnFT_Click(object sender, EventArgs e)
        {
            frmFigurasTridimensionales frmFigurasTridimensionales = new frmFigurasTridimensionales();
            frmFigurasTridimensionales.ShowDialog();
        }
    }
}
