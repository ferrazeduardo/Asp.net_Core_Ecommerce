using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.Repositories
{
    public interface IPedidoRepository
    {
        IEnumerable<Pedido> GetFinalizarCarrinho(List<Produto> Produtos);
    }
}