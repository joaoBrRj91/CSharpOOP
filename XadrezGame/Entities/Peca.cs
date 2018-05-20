
namespace XadrezGame.Entities
{
    public class Peca
    {

        #region Construtores
        public Peca(/*Tabuleiro tabuleiro,*/ Cor cor,string nome)
        {

            //this.Tabuleiro = tabuleiro;
            this.Cor = cor;
            this.Nome = nome;
        }
        #endregion

        #region Propriedades Publicas
        public Cor Cor { get; protected set; }

        public int QtedMovimentos { get; protected set; } = 0;



        public string Nome { get; set; }

        //Associação do tipo composição: Uma peça tem obrigatoriamente uma posição
        public Posicao Posicao { get; set; }

        //Associação do tipo composição: Uma peçoa tem obrigatoriamente uma posição
        //public Tabuleiro Tabuleiro { get; protected set; }

        public void IncrementarQtdMovimentos() => QtedMovimentos++;
        #endregion
    }
}
