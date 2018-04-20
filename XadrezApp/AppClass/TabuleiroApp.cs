using System;
using XadrezApp.Model;
using XadrezApp.Adapter;
using XadrezApp.Builder;
using XadrezGame.Entities;
using XadrezGame.Exceptions;

namespace XadrezApp.AppClass
{
    public  class TabuleiroApp
    {

        public TabuleiroApp()
        {
            InicializarTabuleiroXadrez();
        }

        private void InicializarTabuleiroXadrez()
        {
            if (tabuleiro == null)
                tabuleiro = XadrezGlobalApp.ObterTabuleiroDoJogo();

        }

        private  Tabuleiro tabuleiro;

        public  void ImprimirTabuleiro()
        {

            if (XadrezGlobalApp.Validacao.EhValido)
            {

                for (int i = 0; i < tabuleiro.Linhas; i++)
                {
                    for (int j = 0; j < tabuleiro.Colunas; j++)
                    {
                        if (!tabuleiro.PosicaoEspecificaTabuleiroPossuiPeca(linha: i, coluna: j))
                            Console.Write("- ");
                        else
                            Console.Write(tabuleiro.ObterPecaPorLinhaColuna(linha: i, coluna: j) + " ");

                    }
                    Console.WriteLine();


                }
            }
            else
            {
                ExibirErrosEncontrados();
            }

        }

        public void ExibirErrosEncontrados()
        {
            foreach (var erro in XadrezGlobalApp.Validacao.Erros)
            {
                Console.WriteLine(erro.MensagemException);
            }
        }

        public  void ColocarPecaTabuleiro(PecaModel pecaModel, PosicaoModel posicaoModel)
        {
            var peca = pecaModel.Build(/*tabuleiro:tabuleiro*/posicaoModel:posicaoModel);
            //TODO; Criar um factoryMethod para criar uma peça de acordo com o nome digitado pelo cliente
            try
            {
                tabuleiro.ColocarPeca(peca);

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
    }
}
