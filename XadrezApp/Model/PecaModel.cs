using XadrezApp.Enum;

namespace XadrezApp.Model
{
    public class PecaModel
    {
        public CorPeca Cor { get;  set; }

        public string Nome { get; set; }

        public PosicaoModel Posicao { get; set; }

        public TabuleiroModel Tabuleiro { get; set; }
    }
}
