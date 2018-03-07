using System;
using XadrezApp.AppClass;
using XadrezApp.Model;


//TODO: Retirar a referencia para o dominio,pois no design DDD a camada de UI não conhece o dominio e sim a appication
namespace XadrezGameGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var tabuleiro = new TabuleiroModel(linhas: 8, colunas: 8); 

            TabuleiroApp.ImprimirTabuleiro(tabuleiro);

        }
    }
}
