using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SalesOrders.Models
{
    [Table("ItemPedido")]
    public class ItemPedido
    {
        [Key]
        public int IdItemPedido { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        [JsonIgnore]
        public virtual Produto Produto { get; set; }
        [ForeignKey("Produto")]
        public int IdProduto { get; set; }
        [JsonIgnore]
        public virtual Pedido Pedido { get; set; }
        [ForeignKey("Pedido")]
        public int IdPedido { get; set; }
    }
}
