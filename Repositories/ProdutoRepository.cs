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
        /*retorna uma lista de produtos */
        public IEnumerable<Produto> Produtos => _context.Produtos.Include(c=>c.Categoria);

        /*retorna um produto pelo seu Id */
        public Produto GetProdutobyId(int ProdutoId) => _context.Produtos.FirstOrDefault(c => c.ProdutoId == ProdutoId);
        
        /*retorna uma lista de produtos pela sua categoria */
        public IEnumerable<Produto> GetProdutoCategoria(int CategoriaId) => _context.Produtos.Where(c => c.CategoriaId == CategoriaId).Include(c => c.Categoria);
    }
}