using System.Collections.Generic;

namespace Abstracao
{
    class FiguraGeometricaFactoryMethod
    {
        private FiguraGeometrica Figura;

        public FiguraGeometrica CriarFiguraGeometrica(TipoFiguraEnum tipoFigura, List<double> lados)
        {
            if (tipoFigura == TipoFiguraEnum.Retangulo)
                Figura = new Retangulo(lados);

            else if (tipoFigura == TipoFiguraEnum.Triangulo)
                Figura = new Triangulo(lados);

            return Figura;
        }

        public FiguraGeometrica ObterFiguraGeometrica() => Figura;
    }
}
