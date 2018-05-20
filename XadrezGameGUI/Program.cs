using System;
using XadrezApp.AppClass;



//TODO: Retirar a referencia para o dominio,pois no design DDD a camada de UI não conhece o dominio e sim a appication
namespace XadrezGameGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            XadrezGlobalApp.InicializarJogo();

            try
            {
                do
                {

                    Console.Clear();
                    XadrezGlobalApp.tabuleiroApp.ImprimirTabuleiro();
                    Console.Write("Origem: ");
                    var origem = XadrezGlobalApp.tabuleiroApp.LerPosicaoXadrez();
                    Console.Write("Destino: ");
                    var destino = XadrezGlobalApp.tabuleiroApp.LerPosicaoXadrez();

                    XadrezGlobalApp.jogoXadrezApp.RealizarMovimentoPeca(origem, destino);


                } while (!XadrezGlobalApp.jogoXadrezApp.PartidaXadrezTerminada());

            }
            catch (Exception e)
            {

                 Console.WriteLine(String.Format("Um erro ocorreu no app. Execute novamente: {0}", e.Message));
            }


        }
    }
}
