using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Ecommerce.Repositories;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    public class PedidoController : Controller
    {

        private readonly IPedidoRepository _pedidoRepository;

        public PedidoController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        /*Controler para View Pedido*/
        public IActionResult Pedido(){

            // var user = User.Identity.Name;

            return View();
        }
    }
}