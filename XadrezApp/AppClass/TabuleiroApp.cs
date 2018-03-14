using System;
using XadrezApp.Model;
using XadrezApp.Adapter;
using Core.Entities;
using XadrezApp.Builder;


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

        public  void ColocarPecaTabuleiro(PecaModel pecaModel, PosicaoModel posicaoModel)
        {
            var peca = pecaModel.Build(/*tabuleiro:tabuleiro*/posicaoModel:posicaoModel);
            //TODO; Criar um factoryMethod para criar uma peça de acordo com o nome digitado pelo cliente
            tabuleiro.ColocarPeca(peca);
        }
    }
}
