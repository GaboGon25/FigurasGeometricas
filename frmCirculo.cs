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
            double radioCirculo = Convert.ToDouble(txtRadioCirculo.Text);
            Circulo circulo = new Circulo(radioCirculo);
            double resultadoArea = circulo.CalcularArea();
            double resultadoPerimetro = circulo.CalcularPerimetro();
            txtAreaCirculo.Text = resultadoArea.ToString("0.00");
            txtPerimetroCirculo.Text = resultadoPerimetro.ToString("0.00");
        }
    }
}
