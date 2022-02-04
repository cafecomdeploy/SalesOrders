using System.ComponentModel.DataAnnotations;

namespace SalesOrders.Dtos
{
    public class ProdutoDTO
    {
        [Required]
        [StringLength(200, MinimumLength = 10)]
        public string NomeProduto { get; set; }
        [Required]
        public int Peso { get; set; }
        [Required]
        public int QtdDisponivel { get; set; }
    }
}
