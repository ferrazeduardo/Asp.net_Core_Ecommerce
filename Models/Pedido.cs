using System;
using System.Collections.Generic;

namespace Ecommerce.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public List<PedidoDetalhe> PedidosDetalhe { get; set; }
        public int UsuarioId { get; set; }
        // public virtual Usuario Usuario { get; set; }
        public decimal PedidoTotal { get; set; }
        public DateTime DataPedido { get; set; } 
    }
}