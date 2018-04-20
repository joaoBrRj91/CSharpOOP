
using XadrezApp.Model;
using XadrezGame.Entities;

namespace XadrezApp.Adapter
{
    public static class PosicaoAdapter
    {

        public static Posicao ToPosicao(this PosicaoModel posicaoModel) => new Posicao(posicaoModel.Linha, posicaoModel.Coluna);

        public static PosicaoModel ToPosicaoModel(this Posicao posicao) => new PosicaoModel(posicao.Linha, posicao.Coluna);


    }
}
