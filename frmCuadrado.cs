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
            double Lado = Convert.ToDouble(txtLadoCuadrado.Text);
            Cuadrado cuadrado = new Cuadrado(Lado);
            double resultadoArea = cuadrado.CalcularArea();
            double resultadoPerimetro = cuadrado.CalcularPerimetro();  
            txtAreaCuadrado.Text = resultadoArea.ToString("0.00");
            txtPerimetroCuadrado.Text = resultadoPerimetro.ToString("0.00");
        }
    }
}
