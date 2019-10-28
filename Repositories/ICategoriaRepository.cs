using System.Collections.Generic;
using Ecommerce.Models;

namespace Ecommerce.Repositories
{
    public interface ICategoriaRepository
    {
        /*interface para a implementação do Repositorio Produto */
        IEnumerable<Categoria> Categorias {get;}
    }
}