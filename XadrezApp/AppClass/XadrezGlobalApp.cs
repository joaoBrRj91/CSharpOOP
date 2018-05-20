
using XadrezApp.ConfigApp;
using XadrezApp.Validation;
using XadrezGame.Entities;
using XadrezGame.Entities.XadrezEntities;

namespace XadrezApp.AppClass
{
    public static class XadrezGlobalApp
    {
        private static Tabuleiro tabuleiro;
        public static TabuleiroApp tabuleiroApp { get; private set; }
        public static JogoXadrezApp jogoXadrezApp { get; private set; }

        public static void InicializarJogo()
        {
            tabuleiro = new Tabuleiro(XadrezConfiguracoes.LINHAS_TABULEIRO, XadrezConfiguracoes.COLUNAS_TABULEIRO);
            tabuleiroApp = new TabuleiroApp();
            jogoXadrezApp = new JogoXadrezApp();
            Validacao = new ValidationResult();
        }

        public static ValidationResult Validacao { get; private set; }
    }
}
