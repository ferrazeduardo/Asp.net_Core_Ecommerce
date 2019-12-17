namespace Ecommerce.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Localizacao { get; set; }
        public int NumeroDaCasa { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}