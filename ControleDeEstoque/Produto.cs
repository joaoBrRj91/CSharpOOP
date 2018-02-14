using System;
using System.Collections.Generic;

namespace ControleDeEstoque
{
    class Produto
    {

        #region Campos Privados
        private string nome;
        private double preco;
        private List<string> produtoNomesValidos = new List<string> { "televisao","moveis","sofa","videogame","smartphone" };
        #endregion

        /// <summary>
        ///
        /// </summary>
        /// <param name="fornecedor"></param>
        public Produto(Fornecedor fornecedor)
        {
            this.Fornecedor = fornecedor;
        }


        public Produto()
        {

        }

        #region Propriedades

        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && produtoNomesValidos.Contains(value.ToLower()))
                    nome = value;
            }
        }

        public double Preco
        {
            get
            {
                return this.preco;
            }
            set
            {
                if (value > 0) { preco = value; RecalcularTotalEmEstoque(); }
            }
        }
       

        public int QuantidadeEmEstoque { get; private set; }
        public double ValorTotalEmEstoque { get; private set; }
        public Fornecedor Fornecedor { get; set; }

        #endregion

        #region Metodos Publicos

        public int RealizarEntrada(int quantidade)
        {
            QuantidadeEmEstoque += quantidade;
            RecalcularTotalEmEstoque();
            return QuantidadeEmEstoque;
        }

        public int RealizarSaida(int quantidade)
        {
            QuantidadeEmEstoque -= quantidade;
            RecalcularTotalEmEstoque();
            return QuantidadeEmEstoque;
        }


        public override string ToString()
        {
            var resultado = "Produto " + Nome +
                " possui " + QuantidadeEmEstoque +
                " unidades em estoque.\n O valor total em estoque é "
                + ValorTotalEmEstoque;

            return resultado;
        }

        #endregion

        #region Metodos Privados

        private void RecalcularTotalEmEstoque() => ValorTotalEmEstoque = Preco * QuantidadeEmEstoque;

        #endregion

    }
}
