using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Triangulo : Figuras
    {
        public double ladoTriangulo;
        public double alturaTriangulo;

        public Triangulo(double ladoTriangulo, double alturaTriangulo)
        {
            this.ladoTriangulo = ladoTriangulo;
            this.alturaTriangulo = alturaTriangulo;
        }

        public override double CalcularArea()
        {
            return (ladoTriangulo * alturaTriangulo) / 2;
        }
        public override double CalcularPerimetro()
        {
            return ladoTriangulo * 3;
        }
    }
}
