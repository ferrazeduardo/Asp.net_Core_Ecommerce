using System;
using System.Collections.Generic;

namespace Ecommerce.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public List<PedidoDetalhe> Detalhes { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public decimal PedidoTotal { get; set; }
        public DateTime DataPedido { get; set; } 
    }
}