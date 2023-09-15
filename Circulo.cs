using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Circulo : Figuras
    {
        public double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}
