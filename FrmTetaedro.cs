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
    public partial class FrmTetaedro : Form
    {
        public FrmTetaedro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ladoTetraedro = Convert.ToDouble(txtLadoTetraedro.Text);
            Tetraedro tetraedro = new Tetraedro(ladoTetraedro);
            double resultadoArea = tetraedro.CalcularArea();
            double resultadoVolumen = tetraedro.CalcularVolumen();
            txtAreaTetraedro.Text = resultadoArea.ToString("0.00");
            txtVolumenTetraedro.Text = resultadoVolumen.ToString("0.00");
        }
    }
}
