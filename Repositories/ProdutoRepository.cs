using System.Collections.Generic;
using Ecommerce.Models;
using Ecommerce.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Ecommerce.Repositories
{
    /*Classe implementação do Repositorio para acessar o banco de dados Produtos */
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext context)
        {
            _context=context;
        }
        public IEnumerable<Produto> Produtos => _context.Produtos.Include(c=>c.Categoria);

        public Produto GetProdutobyId(int ProdutoId)
        {
            return _context.Produtos.FirstOrDefault(c=>c.ProdutoId==ProdutoId);
        }

    }
}