using System;
using System.Collections.Generic;

namespace Ecommerce.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public string UserName { get; set; }
        public decimal PedidoTotal { get; set; }
        public DateTime DataPedido { get; set; } 
        public string Localizacao { get; set; }
        public int NumeroDaCasa { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string NumeroPedido { get; set; }
    }
}