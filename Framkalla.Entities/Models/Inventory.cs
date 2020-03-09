using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("inventory")]
    public class Inventory : Base
    {
        [Required]
        [Column("name")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string Name { get; set; }
        
        [Required]
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }
        
        [Required]
        [Column("number_in_stock")]
        public int NumberInStock { get; set; }
    }
}
