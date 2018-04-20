using XadrezApp.Enum;
using XadrezGame.Entities;
using XadrezGame.Entities.XadrezEntities;

namespace XadrezApp.Factory
{
    public static class PecaFactory
    {

        public static Peca ObterPeca(CorPeca cor, NomePeca nome)
        {

            Peca pecaXadrez = null;

            if (nome == NomePeca.Torre)
                pecaXadrez = new Torre((Cor)cor, nome.ToString());
            else if(nome == NomePeca.Rei)
                pecaXadrez =  new Rei((Cor)cor, nome.ToString());

            return pecaXadrez;
        }

    }
}
