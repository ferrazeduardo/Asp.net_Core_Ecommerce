using System.Collections.Generic;

namespace Ecommerce.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; }//uma categoria pode ter varios produtos
    }
}