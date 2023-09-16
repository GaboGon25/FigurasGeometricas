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
    public partial class frmTriangulo : Form
    {
        public frmTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            string inputLadoTriangulo = txtLadoTriangulo.Text;
            string inputAlturaTriangulo = txtAlturaTriangulo.Text;

            if (double.TryParse(inputLadoTriangulo, out double LadoTriangulo) && double.TryParse(inputAlturaTriangulo, out double AlturaTriangulo))
            {
                Triangulo triangulo = new Triangulo(LadoTriangulo, AlturaTriangulo);
                double resultadoArea = triangulo.CalcularArea();
                double resultaoPerimetro = triangulo.CalcularPerimetro();
                txtAreaTriangulo.Text = resultadoArea.ToString("0.00");
                txtPerimetroTriangulo.Text = resultaoPerimetro.ToString("0.00");
            }
            else
            {
                MessageBox.Show("La entrada no es un valor numerico.");
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtLadoTriangulo.Clear();
            txtAlturaTriangulo.Clear();
            txtAreaTriangulo.Clear();
            txtPerimetroTriangulo.Clear();
            txtLadoTriangulo.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

            frmFigurasBidimensionales frmbidimensionales = new frmFigurasBidimensionales();
            frmbidimensionales.Show();
        }
    }
}
