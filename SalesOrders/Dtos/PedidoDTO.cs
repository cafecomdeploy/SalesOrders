using SalesOrders.Models;
using System;
using System.Collections.Generic;

namespace SalesOrders.Dtos
{
    public class PedidoDTO
    {
        public DateTime DataPedido { get; set; }
        public string Vendedor { get; set; }
        public string Observacoes { get; set; }
        public int ClienteId { get; set; }
    }
}
