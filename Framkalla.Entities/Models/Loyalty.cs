using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("loyalty")]
    public class Loyalty : Base
    {
        [Required]
        [Column("country")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Country { get; set; }
       
        [Required]
        [Column("price")]
        public decimal Price { get; set; }
       
        [Required]
        [Column("currency")]
        [StringLength(3, ErrorMessage = "Name can't be longer than 3 characters")]
        public string Currency { get; set; }
       
        [Required]
        [Column("send_after_days")]
        public int SendAfterDays { get; set; }
    }
}
