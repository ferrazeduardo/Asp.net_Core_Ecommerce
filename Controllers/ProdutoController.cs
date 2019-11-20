using Microsoft.AspNetCore.Mvc;
using Ecommerce.Repositories;
using Ecommerce.ViewModels;

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
            var produtos = _produtoRepository.GetProdutoCategoria(CategoriaId);
            return View(model:produtos);
        }

    }
}