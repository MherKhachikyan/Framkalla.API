using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("freight_cost")]

    public class FreightCost : Base
    {
        [Required]
        [Column("freight_type")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]

        public string FreightType { get; set; }
       
        [Required]
        [Column("freight_cost")]
        public decimal FreightCost1 { get; set; }   
        
        [Required]
        [Column("country")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Country { get; set; }
    }
}
