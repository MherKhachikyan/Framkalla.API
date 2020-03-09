using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("freight_rule")]
    public class FreightRule : Base
    {
        [Required]
        [Column("country")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Country { get; set; }
        
        [Required]
        [Column("treshold")]
        public decimal Treshold { get; set; }
        
        [Required]
        [Column("freight_cost")]
        public decimal FreightCost { get; set; } 
        
        [Column("product_group_id")]
        public int? ProductGroupId { get; set; }
        
        [Column("product_id")]
        public int? ProductId { get; set; }
    }
}
