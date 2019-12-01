using System.Collections.Generic;
using System.Linq;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Ecommerce.Repositories;

namespace Ecommerce.Controllers
{
    public class PedidoController : Controller
    {

        private readonly IPedidoRepository _predidoRepository;

        public PedidoController(IPedidoRepository pedidoRepository)
        {
            _predidoRepository = pedidoRepository;
        }
        public IActionResult FinalizarCarrinho(List<Produto> Produtos){

            if(Produtos != null){
                _predidoRepository.GetFinalizarCarrinho(Produtos);
            }

            return Json(Produtos);
        }
    }
}