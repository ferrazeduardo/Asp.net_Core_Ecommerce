using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.ViewModels
{
    /*ViewModel Produto para exibição dos Produtos e das Categorias */

    public class ProdutoViewModel{
        public IEnumerable<Produto> Produtos { get; set; }

        public IEnumerable<Categoria> Categorias { get; set; }

        public Produto produto { get; set; }

        public IEnumerable<Comentario> Comentarios { get; set; }
    }
    
}