using System.Collections.Generic;

namespace Abstracao
{
    public abstract class FiguraGeometrica
    {
        protected List<double> LadosFigura { get; set; }

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
        public abstract double CalcularSemiPerimetro();
    }
}
