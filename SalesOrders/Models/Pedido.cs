using SalesOrders.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SalesOrders.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public string Vendedor { get; set; }
        public PedidoStatus Status { get; set; }
        public string Observacoes { get; set; }
        public ICollection<ItemPedido> ItensPedidos { get; set; }
        [JsonIgnore]
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

    }
}
