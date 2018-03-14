
using Core.Entities;
using XadrezApp.ConfigApp;
using XadrezApp.Model;

namespace XadrezApp.AppClass
{
    public static class XadrezGlobalApp
    {
        private static Tabuleiro tabuleiro;

        public static void  InicializarJogo() => tabuleiro = new Tabuleiro(XadrezConfiguracoes.LINHAS_TABULEIRO, XadrezConfiguracoes.COLUNAS_TABULEIRO);

        public static Tabuleiro ObterTabuleiroDoJogo() => tabuleiro;
    }
}
