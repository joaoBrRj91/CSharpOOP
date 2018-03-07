using System;
using XadrezApp.Model;
using XadrezApp.Adapter;

namespace XadrezApp.AppClass
{
    public class TabuleiroApp
    {

        public static void ImprimirTabuleiro(TabuleiroModel tabuleiroModel)
        {

            var tabuleiro = tabuleiroModel.ToTabuleiro();

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

    }
}
