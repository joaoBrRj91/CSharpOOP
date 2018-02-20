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
        private Peca[,] Pecas;
        #endregion

        #region Propriedades Publicas
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        #endregion

    }
}