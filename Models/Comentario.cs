using System;

namespace Ecommerce.Models
{
    public class Comentario
    {
        public int ComentarioId { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public string ComentarioDoCliente { get; set; }
        public DateTime Data { get; set; }
    }
}