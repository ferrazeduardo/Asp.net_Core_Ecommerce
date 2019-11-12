using System;

namespace Ecommerce.Models
{
    public class Scored
    {
        public int ScoredId { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public int Score { get; set; }
        public DateTime CreateDate { get; set; }
    }
}