using System;
using System.Text;

namespace Core.Entities
{
    public class Posicao: IDisposable
    {
        #region Construtores
        public Posicao(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }
        #endregion

        #region Propriedades
        public int Linha { get; set; }
        public int Coluna { get; set; }
        #endregion

        #region Campos Privados
        private StringBuilder mensagem;
        #endregion

        #region Metodos Publicos
        public override string ToString()
        {
            Dispose();
            mensagem = new StringBuilder();
            mensagem.AppendFormat("Linha: {0}, Coluna: {1}", Linha,Coluna);
            return mensagem.ToString();
        }

        public void Dispose()
        {
            mensagem = null;
        }
        #endregion

    }
}
