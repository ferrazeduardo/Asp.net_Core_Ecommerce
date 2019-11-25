using System.Collections.Generic;
using System.Linq;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class PedidoController : Controller
    {

        private readonly Carrinho _carrinho;

        public PedidoController(Carrinho carrinho)
        {
            _carrinho = carrinho;
        }
        public IActionResult FinalizarCarrinho(IEnumerable<string> Produtos){

            // if(Produtos != null){
            //     _carrinho.GetFinalizarCarrinho(Produtos);
            // }

            return Json(Produtos);
        }
    }
}