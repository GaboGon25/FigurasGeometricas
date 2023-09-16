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
    public partial class frmCirculo : Form
    {
        public frmCirculo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string input = txtRadioCirculo.Text;

            if (double.TryParse(input, out double radioCirculo))
            {
                Circulo circulo = new Circulo(radioCirculo);
                double resultadoArea = circulo.CalcularArea();
                double resultadoPerimetro = circulo.CalcularPerimetro();
                txtAreaCirculo.Text = resultadoArea.ToString("0.00");
                txtPerimetroCirculo.Text = resultadoPerimetro.ToString("0.00");
            }
            else
            {
                MessageBox.Show("La entrada no es un valor numerico.");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtRadioCirculo.Clear();
            txtAreaCirculo.Clear();
            txtPerimetroCirculo.Clear();
            txtRadioCirculo.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

            frmFigurasBidimensionales frmbidimensionales = new frmFigurasBidimensionales();
            frmbidimensionales.Show();
        }

        private void txtRadioCirculo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
