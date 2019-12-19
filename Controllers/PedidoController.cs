using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Ecommerce.Repositories;
using Ecommerce.Models;
using Ecommerce.ViewModels;
using System;
using System.Security.Cryptography;

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

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Pedido(EnderecoViewModel enderecoViewModel){

            if(!ModelState.IsValid){
                return View("Pedido");
            }                   

            var user = User.Identity.Name;

            var pedido = new Pedido(){
                UserName = user,
                Cidade = enderecoViewModel.Cidade,
                Estado = enderecoViewModel.Estado,
                Localizacao = enderecoViewModel.Localizacao,
                DataPedido = DateTime.Now,
                NumeroDaCasa = enderecoViewModel.NumeroDaCasa,
                NumeroPedido = Guid.NewGuid().ToString()
            };

            _pedidoRepository.CriarPedido(pedido);

            return Content(" "+pedido.NumeroPedido);

        }
    }
}