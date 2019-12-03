namespace  Ecommerce.Models
{
    public class ProdutoCarrinho{

        public int ProdutoCarrinhoId { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public string CarrinhoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}