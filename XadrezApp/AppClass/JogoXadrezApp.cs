

using System;
using XadrezApp.Model;
using XadrezGame.Entities.XadrezEntities;

namespace XadrezApp.AppClass
{
    public class JogoXadrezApp
    {


        public PartidaXadrez partidaXadrez { get; private set; }

        public JogoXadrezApp()
        {
            InicializarPartidaDeXadrez();
        }

        private void InicializarPartidaDeXadrez()
        {
            partidaXadrez = new PartidaXadrez(XadrezGlobalApp.tabuleiroApp.tabuleiro);
        }


        public void RealizarMovimentoPeca(PosicaoXadrezModel origem, PosicaoXadrezModel destino)
        {
            XadrezGlobalApp.tabuleiroApp.ExecutarMovimentacaoPeca(origem, destino);
        }

        public bool PartidaXadrezTerminada() => partidaXadrez.partidaTerminada;
    }
}
