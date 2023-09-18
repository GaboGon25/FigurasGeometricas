namespace FigurasGeometricas
{
    public partial class frmCuadrado : Form
    {
        public frmCuadrado()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string input = txtLadoCuadrado.Text;
            if (double.TryParse(input, out double Lado))
            {
                Cuadrado cuadrado = new Cuadrado(Lado);
                double resultadoArea = cuadrado.CalcularArea();
                double resultadoPerimetro = cuadrado.CalcularPerimetro();
                txtAreaCuadrado.Text = resultadoArea.ToString("0.00");
                txtPerimetroCuadrado.Text = resultadoPerimetro.ToString("0.00");
            }
            else
            {
                MessageBox.Show("La entrada no es un valor numerico.");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtLadoCuadrado.Clear();
            txtAreaCuadrado.Clear();
            txtPerimetroCuadrado.Clear();
            txtLadoCuadrado.Focus();
        }
    }
}
