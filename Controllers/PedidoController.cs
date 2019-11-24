using System.Collections.Generic;
using System.Linq;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult FinalizarCarrinho([Bind("CarrinhoId,ProdutoId,Quantidade,Preco,Nome")]List<Produto> Produtos){

            // if(carrinhoViewModels != null){
            //     _carrinho.GetFinalizarCarrinho(carrinhoViewModels);
            // }

            return Content(" "+Produtos.Count);
        }
    }
}