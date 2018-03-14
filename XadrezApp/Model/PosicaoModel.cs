

namespace XadrezApp.Model
{
    public class PosicaoModel
    {
        public PosicaoModel(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public int Linha { get; set; }
        public int Coluna { get; set; }
    }
}
