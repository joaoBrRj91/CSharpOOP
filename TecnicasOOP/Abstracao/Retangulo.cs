using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    class Retangulo : FiguraGeometrica
    {
        //private double Largura;
        //private double Altura;

        public Retangulo(List<double> lados)
        {
            LadosFigura = new List<double>();
            LadosFigura.AddRange(lados);
        }

        public override double CalcularArea() => LadosFigura[0] * LadosFigura[1];

        public override double CalcularPerimetro() => LadosFigura[0] + LadosFigura[1];

        public override double CalcularSemiPerimetro() => (LadosFigura[0] + LadosFigura[1]) / 2;
       
    }
}
