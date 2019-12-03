using Ecommerce.Models;

namespace Ecommerce.Repositories
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
    }
}