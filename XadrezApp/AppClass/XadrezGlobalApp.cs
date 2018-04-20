
using XadrezApp.ConfigApp;
using XadrezApp.Validation;
using XadrezGame.Entities;

namespace XadrezApp.AppClass
{
    public static class XadrezGlobalApp
    {
        private static Tabuleiro tabuleiro;

        public static void InicializarJogo()
        {
            tabuleiro = new Tabuleiro(XadrezConfiguracoes.LINHAS_TABULEIRO, XadrezConfiguracoes.COLUNAS_TABULEIRO);
            Validacao = new ValidationResult();
        }


        public static Tabuleiro ObterTabuleiroDoJogo() => tabuleiro;

        public static ValidationResult Validacao { get; private set; }
    }
}
