using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Triangulo
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }
        public double Perimetro { get; set; }
        public double SemiPerimetro { get; set; }

        public double CalcularPerimetro() => Perimetro = LadoA + LadoB + LadoC;
        
        public double CalcularSemiPerimetro() => SemiPerimetro = Perimetro / 2.0;

        public double CalcularArea()
        {
            CalcularPerimetro();
            CalcularSemiPerimetro();
           return  Math.Sqrt(SemiPerimetro * (SemiPerimetro - LadoA) * (SemiPerimetro - LadoB) * (SemiPerimetro - LadoC));
        }

    }
}
