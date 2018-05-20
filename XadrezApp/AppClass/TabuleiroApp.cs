using System;
using XadrezApp.Model;
using XadrezGame.Entities;
using XadrezGame.Exceptions;
using XadrezApp.Factory;


namespace XadrezApp.AppClass
{
    public class TabuleiroApp
    {


        public Tabuleiro tabuleiro { get; private set; }

        public TabuleiroApp()
        {
            InicializarTabuleiroXadrez();
        }


        private void InicializarTabuleiroXadrez()
        {
            if (tabuleiro == null)
                tabuleiro = XadrezGlobalApp.tabuleiroApp.tabuleiro ;

        }
 
        public  void ImprimirTabuleiro()
        {

            if (XadrezGlobalApp.Validacao.EhValido)
            {

                for (int i = 0; i < tabuleiro.Linhas; i++)
                {

                    Console.Write(8 - i + " ");

                    for (int j = 0; j < tabuleiro.Colunas; j++)
                    {
                        if (!tabuleiro.PosicaoEspecificaTabuleiroPossuiPeca(linha: i, coluna: j))
                            Console.Write("- ");
                        else
                        {
                            ImprimirPeca(tabuleiro.ObterPecaPorLinhaColuna(linha: i, coluna: j));
                            Console.Write(" ");
                        }
                            //Console.Write(tabuleiro.ObterPecaPorLinhaColuna(linha: i, coluna: j) + " ");

                    }
                    Console.WriteLine();


                }

                Console.WriteLine(String.Format("--{0} {1} {2} {3} {4} {5} {6} {7}","a","b","c","d","e","f","g","h"));
            }
            else
            {
                ExibirErrosEncontrados();
            }

        }

        private void ImprimirPeca(Peca peca)
        {

            if (peca.Cor == Cor.Branca)
                Console.Write(peca);
            else
            {
                ConsoleColor corDefault = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = corDefault;
            }
        }

        public void ExibirErrosEncontrados()
        {
            foreach (var erro in XadrezGlobalApp.Validacao.Erros)
            {
                Console.WriteLine(erro.MensagemException);
            }
        }

        private Posicao ConverterPosicaoXadrezParaPosicao(int linha, char coluna)
        {
            //TODO: Criar uma validação caso o usuario informe alguma coluna diferente dos valores A,B,C,D,E,F,G e H
            return new Posicao(tabuleiro.Linhas - linha, tabuleiro.Colunas - coluna);
        }

        public  void ColocarPecaTabuleiro(PecaModel pecaModel, PosicaoXadrezModel posicaoXadrezModel)
        {
            var peca = PecaFactory.ObterPeca(pecaModel.Cor, pecaModel.Nome);
            var posicao = ConverterPosicaoXadrezParaPosicao(posicaoXadrezModel.Linha, posicaoXadrezModel.Coluna);

            //TODO; Criar um factoryMethod para criar uma peça de acordo com o nome digitado pelo cliente
            try
            {
                tabuleiro.ColocarPeca(peca,posicao);

            }
            catch (TabuleiroException tex)
            {
                XadrezGlobalApp.Validacao.AddErro(tex.Message);

            }
            catch (Exception e)
            {
                XadrezGlobalApp.Validacao.AddErro(e.Message, e.StackTrace);
            }
        }

        public void ExecutarMovimentacaoPeca(PosicaoXadrezModel posicaoOrigem, PosicaoXadrezModel posicaoDestino)
        {
            var posicaoAtual =ConverterPosicaoXadrezParaPosicao(posicaoOrigem.Linha, posicaoOrigem.Coluna);
            var posicaoAtualizada = ConverterPosicaoXadrezParaPosicao(posicaoOrigem.Linha, posicaoOrigem.Coluna);

            XadrezGlobalApp.jogoXadrezApp.partidaXadrez.ExecutarMovimento(posicaoAtual, posicaoAtualizada);

        }

        public PosicaoXadrezModel LerPosicaoXadrez()
        {

            string posicaoInformada = Console.ReadLine();
            char colunaAlfabetica = posicaoInformada[0];
            int linha = int.Parse(posicaoInformada[1].ToString());
            return new PosicaoXadrezModel(linha, colunaAlfabetica);
        }

    }
}
