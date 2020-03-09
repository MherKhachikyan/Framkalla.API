using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("average_order_size_data")]
    public class AverageOrderSizeData : Base
    {
        [Required]
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        [Required]
        [Column("average_order_size")]
        public decimal AverageOrderSize { get; set; }
    }
}
