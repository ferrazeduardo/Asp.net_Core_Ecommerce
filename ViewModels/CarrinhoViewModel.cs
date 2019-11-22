using Ecommerce.Models;

namespace Ecommerce.ViewModels
{
    public class CarrinhoViewModel
    {
        public Carrinho Carrinho { get; set; }

        public decimal GetTotal { get; set; }

        public int Quantidade { get; set; }

        public int ProdutoId { get; set; }
        public decimal Preco { get; set; }
        public string Nome { get; set; }
    }
}