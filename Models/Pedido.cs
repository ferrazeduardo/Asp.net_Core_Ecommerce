namespace Ecommerce.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public string Nome { get; set; }
        public string Quantidade { get; set; }
        public string Preco { get; set; }
        public Produto Produto{ get; set;}
    }
}