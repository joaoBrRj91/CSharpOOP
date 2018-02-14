using System;
using System.Collections.Generic;

namespace Abstracao
{
    class Triangulo : FiguraGeometrica
    {
        //private double LadoA;
        //private double LadoB;
        //private double LadoC;
        private double Perimetro;
        private double SemiPerimetro;


        public Triangulo(List<double> lados)
        {
            LadosFigura = new List<double>();
            LadosFigura.AddRange(lados);

        }

        public override double CalcularPerimetro() => Perimetro = LadosFigura[0] + LadosFigura[1] + LadosFigura[3];

        public override double CalcularSemiPerimetro() => SemiPerimetro = Perimetro / 2.0;

        public override double CalcularArea()
        {
            CalcularPerimetro();
            CalcularSemiPerimetro();
            return Math.Sqrt(SemiPerimetro * (SemiPerimetro - LadosFigura[0]) * (SemiPerimetro - LadosFigura[1]) * (SemiPerimetro - LadosFigura[3]));
        }
    }
}


