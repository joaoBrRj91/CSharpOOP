
namespace XadrezGame.Entities.XadrezEntities
{
    public class PartidaXadrez
    {

        private Tabuleiro tabuleiro;
        private Cor jogadorAtual;
        private int turno;
        public bool partidaTerminada { get; private set; }

        public PartidaXadrez(Tabuleiro tabuleiro)
        {

            this.tabuleiro = tabuleiro;
        }


        private void AlterarJogadorAtual(Cor jogadorAtual)
        {
            this.jogadorAtual = jogadorAtual;
        }

        private void AvancarTurno() => turno++;

        public int ObterTurnoAtual() => turno;

        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            var pecaMovimentada =tabuleiro.RetirarPecaDaPosicao(origem);
            pecaMovimentada.IncrementarQtdMovimentos();

            var pecaCapturada = tabuleiro.RetirarPecaDaPosicao(destino);

            tabuleiro.ColocarPeca(pecaMovimentada,destino);

        }
    }
}
