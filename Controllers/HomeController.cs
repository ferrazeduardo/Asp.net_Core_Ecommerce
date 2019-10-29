using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ecommerce.Models;
using Ecommerce.Repositories;

namespace Ecommerce.Controllers
{
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

        public IActionResult Index(){
            
            var produtos = _produtoRepository.Produtos;

            return View(model: produtos);
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
