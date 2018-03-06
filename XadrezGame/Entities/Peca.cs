
namespace Core.Entities
{
    public class Peca
    {

        #region Construtores
        public Peca(Posicao posicao, Tabuleiro tabuleiro,Cor cor)
        {
            this.Posicao = posicao;
            this.Tabuleiro = tabuleiro;
            this.Cor = cor;
        }
        #endregion

        #region Propriedades Publicas
        public Cor Cor { get; protected set; }

        public int QtedMovimentos { get; protected set; } = 0;

        //Associação do tipo composição: Uma peça tem obrigatoriamente uma posição
        public Posicao Posicao { get; set; }

        //Associação do tipo composição: Uma peçoa tem obrigatoriamente uma posição
        public Tabuleiro Tabuleiro { get; protected set; }
        #endregion
    }
}
