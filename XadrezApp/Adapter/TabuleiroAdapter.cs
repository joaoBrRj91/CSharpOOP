using Core.Entities;
using XadrezApp.Model;

namespace XadrezApp.Adapter
{
    public  static class TabuleiroAdapter
    {
        public static Tabuleiro ToTabuleiro(this TabuleiroModel tabuleiroModel)
        {
            Tabuleiro tabuleiro = new Tabuleiro(tabuleiroModel.Linhas, tabuleiroModel.Colunas);
            return tabuleiro;
        }


        public static TabuleiroModel ToTabuleiroModel(this Tabuleiro tabuleiro)
        {
            TabuleiroModel tabuleiroModel = new TabuleiroModel(tabuleiro.Linhas, tabuleiro.Colunas);
            return tabuleiroModel;
        }
    }
}
