namespace Core.Entities
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

        public Peca ObterPecaPorLinhaColuna(int linha, int coluna) => Pecas[linha, coluna];

        public bool PosicaoEspecificaTabuleiroPossuiPeca(int linha, int coluna)
        {
            if (Pecas[linha, coluna] == null)
                return false;
            return true;
        } 

    }
}