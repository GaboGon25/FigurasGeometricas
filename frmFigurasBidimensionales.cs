using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricas
{
    public partial class frmFigurasBidimensionales : Form
    {
        public frmFigurasBidimensionales()
        {
            InitializeComponent();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            frmCirculo frmCirculo = new frmCirculo();
            frmCirculo.ShowDialog();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            frmCuadrado frmCuadrado = new frmCuadrado();
            frmCuadrado.ShowDialog();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            frmTriangulo frmTriangulo = new frmTriangulo();
            frmTriangulo.ShowDialog();
        }
    }
}
