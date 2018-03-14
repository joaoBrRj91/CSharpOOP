
using Core.Entities;
using XadrezApp.Model;
using XadrezApp.Adapter;
using System;

namespace XadrezApp.Builder
{
    public static class PecaBuilder
    {
      
        public static Peca Build(this PecaModel pecaModel,PosicaoModel posicaoModel /*Tabuleiro tabuleiro*/)
        {

            var posicao = posicaoModel.ToPosicao();
            var corPeca = Convert.ToInt32(pecaModel.Cor);

            /*TODO: Criar a camada de fundação(serviços tecnicos de baixo nivel) para conter 
            para que essa logica seja adicionada em uma classe de utilitarios de projetos "Util"
            de co 
            */
            var peca = new Peca(/*tabuleiro,*/ (Cor)corPeca, pecaModel.Nome);
            peca.Posicao = posicao;
     
            return peca;
        }
    }
}
