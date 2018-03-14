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
            XadrezGlobalApp.InicializarJogo();

            PecaModel peca1 = new TorreModel() { Nome = "Torre", Cor = XadrezApp.Enum.CorPeca.Preta };
            PecaModel peca2 = new ReiModel() { Nome = "Rei", Cor = XadrezApp.Enum.CorPeca.Preta };

            var posicao1 = new PosicaoModel(linha:0,coluna:0);
            var posicao2 = new PosicaoModel(linha: 3, coluna: 4);


            TabuleiroApp tabApp = new TabuleiroApp();
            tabApp.ImprimirTabuleiro();
            tabApp.ColocarPecaTabuleiro(pecaModel: peca1, posicaoModel: posicao1);
            tabApp.ColocarPecaTabuleiro(pecaModel: peca2, posicaoModel: posicao2);


        }
    }
}
