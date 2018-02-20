using System;
using XadrezApp.Tabuleiro;

namespace XadrezGameGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(linha: 3, coluna: 4);

            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
