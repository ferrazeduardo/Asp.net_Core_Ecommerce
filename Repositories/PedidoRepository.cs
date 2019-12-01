using System.Collections.Generic;
using Ecommerce.Models;
using Ecommerce.Data;
using System.Linq;

namespace Ecommerce.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {

        private readonly AppDbContext _context;
        
        public PedidoRepository(AppDbContext context){
            _context=context;
        }

        public IEnumerable<Pedido> GetFinalizarCarrinho(List<Produto> Produtos){
            
            var produtos = new List<Produto>();

            foreach(var produto in Produtos){
                produtos = _context.ProdutosCarrinho.Where(p => p.Produto.ProdutoId == produto.ProdutoId && p.CarrinhoId == CarrinhoId);
            }

            if(produtos != null){
                _context.Pedido.UpdateRange(produtos);
            }

            _context.SaveChanges();

            return _context.ProdutosCarrinho;
        }
    }
}


        