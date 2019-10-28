using System.Collections.Generic;
using Ecommerce.Models;
using Ecommerce.Data;

namespace Ecommerce.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
           /*Classe implementação do Repositorio para acessar o banco de dados Categorias */
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context=context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}