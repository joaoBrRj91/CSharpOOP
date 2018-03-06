using Core.Entities;
using System;


namespace XadrezApp.App
{
    public class TabuleiroApp
    {

        public static void ImprimirTabuleiro()
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

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
