namespace  Ecommerce.Models
{
    public class ProdutoCarrinho{

        public int ProdutoCarrinhoId { get; set; }
        public Produto Produto { get; set; }
        public string CarrinhoId { get; set; }
        public int Quantidade { get; set; }
    }
}