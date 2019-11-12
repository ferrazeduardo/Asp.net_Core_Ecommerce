using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Ecommerce.Models;
using Ecommerce.Data;

namespace Ecommerce.Repositories
{
    public class ScoredRepository : IScoredRepository
    {
        private readonly AppDbContext _context;

        public ScoredRepository(AppDbContext context)
        {
            _context=context;
        }

        public IEnumerable<Scored> GetScored(int ProdutoId)=> _context.Scoreds.Where(s => s.ProdutoId == ProdutoId).Include(s=>s.Produto);
    }
}