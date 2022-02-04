using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesOrders.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int Peso { get; set; }
        public int QtdDisponivel { get; set; }
        public ICollection<ItemPedido> ItensPedidos { get; set; }
    }
}
