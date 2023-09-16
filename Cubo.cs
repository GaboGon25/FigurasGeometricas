using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Cubo: Figuras
    {
        public double ladoCubo;

        public Cubo(double ladoCubo)
        {
            this.ladoCubo = ladoCubo;
        }

        public override double CalcularArea()
        {
            return 6*(ladoCubo*ladoCubo);
        }

        public override double CalcularVolumen()
        {
            return ladoCubo * ladoCubo * ladoCubo;
        }
    }
}
