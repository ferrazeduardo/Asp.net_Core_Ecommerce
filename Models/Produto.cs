using System.Collections.Generic;

namespace Ecommerce.Models{

    public class Produto{
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string ImagemUrl { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int CategoriaId { get; set; }//informa que existe uma relacionamento entre lanche e categoria
        public virtual Categoria Categoria { get; set; }
        public List<Scored> Scoreds { get; set; }
        public List<Comentario> Comentarios { get; set; }
    }

}