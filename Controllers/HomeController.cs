using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ecommerce.ViewModels;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        List<ProdutoViewModel> produtos = new List<ProdutoViewModel>{
            new ProdutoViewModel{
                Nome="Feijao",
                Preco=3,
                ProdutoId=1
            },
            new ProdutoViewModel{
                Nome="Arroz",
                Preco=4,
                ProdutoId=2
            },
            new ProdutoViewModel{
                Nome="Macarrão",
                Preco = 9,
                ProdutoId=3
            }
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() => View(model: produtos);

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
