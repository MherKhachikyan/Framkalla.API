using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("order_item_order_item")]
    public class OrderItemOrderItem : Base
    {
        [Required]
        [Column("order_item_main")]
        [ForeignKey(nameof(OrderItem))]
        public int OrderItemMain { get; set; }

        public virtual OrderItem OrderItem { get; set; }
       
        [Required]
        [Column("order_item_related")]
        public int OrderItemRelated { get; set; }
    }
}
