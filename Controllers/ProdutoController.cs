using Microsoft.AspNetCore.Mvc;
using Ecommerce.ViewModels;

namespace Ecommerce.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult ExibirDetalhes(int ProdutoId){

            var produto = new ProdutoViewModel{
                Nome="feijão",
                Categoria="Grãos",
                Preco=3,
                Descricao="1 Kilo de grão da cor marrom",
                Quantidade=2
            };

            return View(model: produto);
        }
    }
}