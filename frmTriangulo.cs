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
            double LadoTriangulo = Convert.ToDouble(txtLadoTriangulo.Text);
            double AlturaTriangulo = Convert.ToDouble(txtAlturaTriangulo.Text); 
            Triangulo triangulo = new Triangulo(LadoTriangulo, AlturaTriangulo);
            double resultadoArea = triangulo.CalcularArea();
            double resultaoPerimetro = triangulo.CalcularPerimetro();
            txtAreaTriangulo.Text = resultadoArea.ToString("0.00");
            txtPerimetroTriangulo.Text = resultaoPerimetro.ToString("0.00");
        }
    }
}
