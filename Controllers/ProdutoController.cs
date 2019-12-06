using Microsoft.AspNetCore.Mvc;
using Ecommerce.Repositories;
using Ecommerce.ViewModels;
using System.Linq;
using System.Collections.Generic;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository=produtoRepository;
        }

        /*Exibir os Detalhes do Produto */
        public IActionResult ExibirDetalhes(int ProdutoId)
        {
            var produto = _produtoRepository.GetProdutobyId(ProdutoId);
            var comentarios = _produtoRepository.GetComentarios(ProdutoId);

            var produtoViewModel = new ProdutoViewModel{
                produto = produto,
                Comentarios = comentarios
            };


            return View(model: produtoViewModel);
        }

        /*Exibir Produtos por categorias */
        public IActionResult ExibirCategoriaProdutos(int CategoriaId)
        {
            var produtos = _produtoRepository.GetProdutoCategoria(CategoriaId).ToList();
            return View(model:produtos);
        }

        /*procurar o produto desejado*/
        public IActionResult Procurar(string stringProcurar){
            
            string _stringProcurar = stringProcurar;

            IEnumerable<Produto> produtos;

            if(string.IsNullOrEmpty(_stringProcurar)){
                produtos = _produtoRepository.Produtos.OrderBy(p => p.ProdutoId);
            }
            else{
                produtos = _produtoRepository.Produtos.Where(p => p.Nome.ToLower().Contains(_stringProcurar.ToLower()));
            }

            return View("~/Views/Home/Index.cshtml",new ProdutoViewModel {Produtos = produtos.ToList()});
        }
    }
}