using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult ExibirDetalhes(int ProdutoId){


            return View();
        }
    }
}