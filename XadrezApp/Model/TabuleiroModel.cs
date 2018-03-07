

namespace XadrezApp.Model
{
    public class TabuleiroModel
    {
        #region Construtores
        public TabuleiroModel(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
        }
        #endregion

        #region Propriedades Públicas
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        #endregion
    }
}
