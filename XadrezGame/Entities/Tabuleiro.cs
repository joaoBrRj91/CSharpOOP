

using XadrezGame.Exceptions;

namespace XadrezGame.Entities
{
    public class Tabuleiro
    {

        #region Construtores
        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            Pecas = new Peca[Linhas, colunas];
        }
        #endregion

        #region Campos Privados
        /*TODO: Podemos refatorar posteriormente para um objeto "Posicao"; ou seja, teriamos
         uma matriz de posição, visto que o tabuleiro é composto dessa forma, e a posição iria possuir
         dois vetores contendo as peças do usuario e adversario*/
        private Peca[,] Pecas;
        #endregion

        #region Propriedades Publicas
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        #endregion

        #region Métodos Públicos
        public Peca ObterPecaPorLinhaColuna(int linha, int coluna) => Pecas[linha, coluna];

        public bool PosicaoEspecificaTabuleiroPossuiPeca(int linha, int coluna)
        {
            if (Pecas[linha, coluna] == null)
                return false;
            return true;
        }

        public void ColocarPeca(Peca peca)
        {
            if (ExistePecaNaPosicao(peca.Posicao))
                throw new TabuleiroException("Já existe uma peça nessa posição!!.");

            Pecas[peca.Posicao.Linha, peca.Posicao.Coluna] = peca;

        }
        public bool ExistePecaNaPosicao(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return ObterPecaPorLinhaColuna(posicao.Linha, posicao.Coluna) != null;

        }

        public void ValidarPosicao(Posicao posicao)
        {
            if (!PosicaoEhValida(posicao))
                throw new TabuleiroException("Posição Invalida!!.");
        }

        public bool PosicaoEhValida(Posicao posicao)
        {
            return (posicao.Linha < 0 || posicao.Linha >= Linhas || posicao.Coluna < 0 || posicao.Coluna >= Colunas);
        }


        #endregion

    }
}