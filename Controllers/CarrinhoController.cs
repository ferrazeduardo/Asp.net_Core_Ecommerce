using Ecommerce.Repositories;
using Ecommerce.ViewModels;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Ecommerce.Controllers
{
    public class CarrinhoController : Controller
    {
        /*Controller Carrinho de compras */
        private readonly IProdutoRepository _produtoRepository;
        private readonly Carrinho _carrinho;

        public CarrinhoController(IProdutoRepository produtoRepository, Carrinho carrinho)
        {
            _produtoRepository = produtoRepository;
            _carrinho = carrinho;
        }

        /*função para  obtendo o carrinho */
        public IActionResult Index(){

            _carrinho.ProdutosCarrinho = _carrinho.GetProdutosCarrinho();

            var carrinhoViewModel = new CarrinhoViewModel{
                Carrinho = _carrinho,
                GetTotal = _carrinho.GetCarrinhoTotal()
            };

            return View(carrinhoViewModel);
        }

        /*função adcionar ao carrinho do controller Carrinho */
        public RedirectToActionResult Adicionar(int ProdutoId){
            
            var produto = _produtoRepository.Produtos.FirstOrDefault(p => p.ProdutoId == ProdutoId);

            if( produto != null){
                _carrinho.AdicionarAoCarrinho(produto,1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult Remover(int ProdutoId){
            
            var produto = _produtoRepository.Produtos.FirstOrDefault(p => p.ProdutoId == ProdutoId);

            if(produto != null){
                _carrinho.RemoverDoCarrinho(produto);
            }

            return RedirectToAction("Index");
        }
    }
}