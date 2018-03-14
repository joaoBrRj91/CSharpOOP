using Core.Entities;

namespace XadrezGame.XadrezEntities
{
    public class Torre : Peca
    {
        public Torre(/*Tabuleiro tabuleiro, */Cor cor,string nome) : base(/*tabuleiro, */cor, nome)
        {

        }

        public override string ToString()
        {
            //TODO: Refatorar para uma classe de configuração para imprimir a "imagem" da peça
            return "T";
        }
    }
}
