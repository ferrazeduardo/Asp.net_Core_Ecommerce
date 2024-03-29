namespace Ecommerce.Models
{
    public class PedidoDetalhe
    {
        public int PedidoDetalheId { get; set; }
        public string NumeroPedido { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public virtual Produto Produto { get; set; }
    }
}