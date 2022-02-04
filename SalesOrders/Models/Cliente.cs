using SalesOrders.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesOrders.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double LimiteCredito { get; set; }
        public int CartaoCredito { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }
        public ClienteStatus Status { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
