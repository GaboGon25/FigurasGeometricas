using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Cuadrado : Figuras
    {
        public double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public override double CalcularArea()
        {
            return lado * lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * lado;
        }

    }
}
