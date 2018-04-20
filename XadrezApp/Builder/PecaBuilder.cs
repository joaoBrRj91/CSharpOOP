
using XadrezApp.Model;
using XadrezApp.Adapter;
using System;
using XadrezGame.Entities;
using XadrezApp.Factory;

namespace XadrezApp.Builder
{
    public static class PecaBuilder
    {
      
        public static Peca Build(this PecaModel pecaModel,PosicaoModel posicaoModel /*Tabuleiro tabuleiro*/)
        {

           
            /*TODO: Criar a camada de fundação(serviços tecnicos de baixo nivel) para conter 
            para que essa logica seja adicionada em uma classe de utilitarios de projetos "Util"
            de co 
            */
            var peca = PecaFactory.ObterPeca(pecaModel.Cor, pecaModel.Nome);
            var posicao = posicaoModel.ToPosicao();
            peca.Posicao = posicao;
     
            return peca;
        }
    }
}
