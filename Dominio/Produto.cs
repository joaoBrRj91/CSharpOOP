using System;
using System.Globalization;

namespace Dominio
{
    public class Produto : IComparable
    {
        public int Id { get;  protected set; }
        public string CodigoInterno { get; protected set; }
        public string Descricao { get; protected set; }
        public decimal Preco { get; protected set; }

        public override string ToString()
        {
            return CodigoInterno
                + ","
                + Descricao
                + ","
                + Preco.ToString("G2", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// 
        /// O algoritmo de ordenação do metodo sort, que é implementado pelo List<T>, verifica se a classe, do objeto 
        /// manipulado, implementa o IComparable para executar a logica sobrescrita, caso contrario
        /// o algoritmo de ordenação executa sua logica  padrão ordenando por ordem crescente
        /// 
        /// O retorno do CompareTo pode ser os seguintes valores 0, 1 e -1
        /// 
        ///  0: Os valores são iguais.
        ///  
        ///  1: o valor da esquerda é maior do que a da direta(O objeto que chamou o metodo
        /// CompareTo passando o obejto de comparação). Caso isso ocorra o algoritmo irá ordenar,pois
        /// opadrão dele é ordenar de forma crescente.
        /// 
        /// -1: o valor da esquerda é menor do que a da direta(O objeto que chamou o metodo
        /// CompareTo passando o obejto de comparação). Caso isso ocorra o algoritmo não irá ordenar passando
        /// para o proximo objeto da verificação
        /// 
        /// </summary>
        /// <title-method>Ordenação por descrição de forma crescente e por preço de forma descrescente</title-method>>
        /// <param name="proximoProduto"></param>
        /// <returns></returns>
        public int CompareTo(object proximoProduto)
        {
            Produto proximoProdutoDaLista  = (Produto)proximoProduto;
            int resultado = Descricao.CompareTo(proximoProdutoDaLista.Descricao);

            if (resultado != 0)
                return resultado;
            else
                return  - Preco.CompareTo(proximoProdutoDaLista.Preco);

        }
    }
}
