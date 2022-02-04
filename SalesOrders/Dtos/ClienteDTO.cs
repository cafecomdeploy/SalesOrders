using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesOrders.Dtos
{
    public class ClienteDTO
    {
        [Required]
        [StringLength(200, MinimumLength = 10)]
        public string Nome { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }
        [Required]
        public double LimiteCredito { get; set; }
        [Required]
        public int CartaoCredito { get; set; }
        [Required]
        public string Contato { get; set; }
    }
}
