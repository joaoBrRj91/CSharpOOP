namespace Dominio
{
    public class ItemPedido
    {
        public int Id { get; protected set; }
        public int Quantidade { get; protected set; }
        public decimal PorcentagemDesconto { get; protected set; }
        public decimal SubTotal { get; protected set; }
        public Produto Produto { get; protected set; }
        public Pedido Pedido { get; protected set; }

        public ItemPedido(Produto Produto, Pedido Pedido)
        {
            this.Produto = Produto;
            this.Pedido = Pedido;
        }

        protected ItemPedido()
        {

        }

        public decimal CalcularSubTotalPedido()
        {
            if (SubTotal == 0)
            {
                decimal desconto = (Produto.Preco * PorcentagemDesconto / 100);
                return SubTotal = (Produto.Preco - desconto) * Quantidade;
            }
            else
            {
                return SubTotal;
            }
        }

        public override string ToString()
        {
            return Produto.Descricao
                 + "Preço : "
                 + Produto.Preco.ToString("F2")
                 + ", Qte : "
                 + Quantidade
                 + ", Desconto : "
                 + PorcentagemDesconto + "%"
                 + "SubTotal : "
                 + SubTotal;
        }

    }
}
