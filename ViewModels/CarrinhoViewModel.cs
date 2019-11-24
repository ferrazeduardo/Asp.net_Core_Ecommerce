using Ecommerce.Models;

namespace Ecommerce.ViewModels
{
    public class CarrinhoViewModel
    {
        public Carrinho Carrinho { get; set; }
        public string CarrinhoId { get; set; }
        public decimal GetTotal { get; set; }
    }
}