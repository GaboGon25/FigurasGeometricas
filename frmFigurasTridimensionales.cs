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
    public partial class frmFigurasTridimensionales : Form
    {
        public frmFigurasTridimensionales()
        {
            InitializeComponent();
        }

        private void btnEsfera_Click(object sender, EventArgs e)
        {
            FrmEsfera frmEsfera = new FrmEsfera();
            frmEsfera.ShowDialog();
        }

        private void btnCubo_Click(object sender, EventArgs e)
        {
            FrmCubocs frmCubocs = new FrmCubocs();
            frmCubocs.ShowDialog();
        }

        private void btnTetraedro_Click(object sender, EventArgs e)
        {
            FrmTetaedro frmTetaedro = new FrmTetaedro();
            frmTetaedro.ShowDialog();
        }
    }
}
