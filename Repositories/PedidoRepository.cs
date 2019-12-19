using System;
using Ecommerce.Models;
using Ecommerce.Data;

namespace Ecommerce.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _context;
        private readonly Carrinho _carrinho;

        public PedidoRepository(AppDbContext context,Carrinho carrinho)
        {
            _context = context;
            _carrinho = carrinho;
        }

        /*medito criar pedido para persistencia dos produtos do carrinho*/
        public void CriarPedido(Pedido pedido)
        {
            pedido.PedidoTotal = _carrinho.GetCarrinhoTotal();

            _context.Pedidos.Add(pedido);

            var produtosCarrinho = _carrinho.GetProdutosCarrinho();

            foreach (var produtoCarrinho in produtosCarrinho)
            {
                var pedidoDetalhe = new PedidoDetalhe{
                    NumeroPedido = pedido.NumeroPedido,
                    ProdutoId = produtoCarrinho.ProdutoId,
                    Preco = produtoCarrinho.Preco,
                    Quantidade = produtoCarrinho.Quantidade
                };

                _context.PedidoDetalhes.Add(pedidoDetalhe);
            }

            _context.SaveChanges();
        }
    }
}