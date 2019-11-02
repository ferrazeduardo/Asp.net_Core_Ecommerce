using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ecommerce.Models;
using Ecommerce.Repositories;
using Ecommerce.ViewModels;

namespace Ecommerce.Controllers
{
    /*Home Controller */
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IProdutoRepository _produtoRepository;

        public HomeController(ILogger<HomeController> logger,IProdutoRepository produtoRepository,ICategoriaRepository categoriaRepository)
        {
            _logger = logger;
            _categoriaRepository=categoriaRepository;
            _produtoRepository=produtoRepository;
        }
        /*Controlador da Pagina Index, gera a pagina inicial do site */
        public IActionResult Index(){
            
            var produtosViewModel = new ProdutoViewModel(){
                Produtos = _produtoRepository.Produtos,
                Categorias = _categoriaRepository.Categorias
            };

            return View(model: produtosViewModel);
        } 

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
