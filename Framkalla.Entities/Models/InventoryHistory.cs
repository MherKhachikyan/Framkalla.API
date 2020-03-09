using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("inventory_history")]
    public class InventoryHistory : Base
    {
        [Required]
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }
      
        [Required]
        [Column("deducted")]
        public int Deducted { get; set; }
      
        [Required]
        [Column("inventory_id")]
        [ForeignKey(nameof(Inventory))]
        public int InventoryId { get; set; }

        public virtual Inventory Inventory { get; set; }
    }
}
