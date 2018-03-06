using System;
using XadrezApp.App;


//TODO: Retirar a referencia para o dominio,pois no design DDD a camada de UI não conhece o dominio e sim a appication
namespace XadrezGameGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            TabuleiroApp.ImprimirTabuleiro();
        }
    }
}
