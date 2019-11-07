using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;
using Ecommerce.ViewModels;

namespace Ecommerce.Components
{
    public class  CarrinhoResumo : ViewComponent
    {
        private readonly Carrinho _carrinho;
        public CarrinhoResumo(Carrinho carrinho) => _carrinho = carrinho;

        public IViewComponentResult Invoke()
        {

            var itens = _carrinho.GetProdutosCarrinho();

            _carrinho.ProdutosCarrinho = itens;

            var carrinhoViewModel = new CarrinhoViewModel{
                Carrinho = _carrinho,
                GetTotal = _carrinho.GetCarrinhoTotal()
            };

            return View(carrinhoViewModel);

        }
    }
}