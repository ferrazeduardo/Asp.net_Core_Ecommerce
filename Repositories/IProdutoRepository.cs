using System.Collections.Generic;
using Ecommerce.Models;

namespace Ecommerce.Repositories
{
    public interface IProdutoRepository
    {
        /*interface para a implementação do Repositorio Produto */
        IEnumerable<Produto> Produtos {get;}

        Produto GetProdutobyId(int ProdutoId);

        IEnumerable<Produto> GetProdutoCategoria(int CategoriaId);
    }
}