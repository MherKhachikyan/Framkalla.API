using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("exchange_rate")]
    public class ExchangeRate : Base
    {
        [Required]
        [Column("rate")]
        public decimal Rate { get; set; }
       
        [Required]
        [Column("rate_currency")]
        [StringLength(4, ErrorMessage = "Name can't be longer than 4 characters")]
        public string RateCurrency { get; set; }
    }
}
