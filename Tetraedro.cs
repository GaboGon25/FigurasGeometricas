using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Tetraedro: Figuras
    {
        public double ladoTetraedro;

        public Tetraedro(double ladoTetraedro)
        {
            this.ladoTetraedro = ladoTetraedro;
        }

        public override double CalcularArea()
        {
            return Math.Sqrt(3) * ladoTetraedro * ladoTetraedro;
        }

        public override double CalcularVolumen()
        {
            return (Math.Sqrt(2) * ladoTetraedro * ladoTetraedro * ladoTetraedro)/12;
        }
    }
}
