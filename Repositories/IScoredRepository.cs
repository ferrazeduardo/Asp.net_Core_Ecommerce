using System.Collections.Generic;
using Ecommerce.Models;

namespace Ecommerce.Repositories
{
    public interface IScoredRepository
    {
        IEnumerable<Scored> GetScored(int ProdutoId);
        
    }
}