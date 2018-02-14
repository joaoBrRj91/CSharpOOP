using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Pedido
    {

        public int Id { get; protected set; }
        public string CodigoInterno { get; protected set; }
        public DateTime Data { get; protected set; }
        public decimal ValorTotal { get; protected set; }
        public ICollection<ItemPedido> ItensPedido { get; protected set; }


        public Pedido(DateTime dataPedido)
        {
            Data = Data;
            ItensPedido = new List<ItemPedido>();
        }

        protected Pedido()
        {

        }

        public decimal CalcularValorTotalPedido()
        {

            if (ValorTotal == 0)
            {
                decimal soma = 0;

                foreach (var item in ItensPedido)
                {
                    soma += item.CalcularSubTotalPedido();
                }

                return ValorTotal = soma;
            }
            else
                return ValorTotal;
        }


        public override string ToString()
        {
            StringBuilder mensagemDetalhePedido = new StringBuilder();

            mensagemDetalhePedido.AppendLine("Pedido : " + CodigoInterno);
            mensagemDetalhePedido.AppendLine("Data : " + String.Format("{0:dd/MM/yyyy}",Data));
            mensagemDetalhePedido.AppendLine("Itens do Pedido : ");

            foreach (var item in ItensPedido)
            {
                mensagemDetalhePedido.Append(item.Produto.Descricao + ",");
                mensagemDetalhePedido.Append("Preço: " + item.Produto.Preco + ",");
                mensagemDetalhePedido.Append("Qte: " + item.Quantidade + ",");
                mensagemDetalhePedido.Append("Desconto: " + item.PorcentagemDesconto.ToString("G2") + ",");
                mensagemDetalhePedido.Append("SubTotal : " + item.SubTotal.ToString("G2"));
                mensagemDetalhePedido.AppendLine();
            }

            mensagemDetalhePedido.AppendLine("Total do Pedido : " + ValorTotal);

            return mensagemDetalhePedido.ToString();
        }
    }
}
