using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("product_image")]
    public class ProductImage : Base
    {
        [Required]
        [Column("url")]
        public string Url { get; set; }
       
        [Required]
        [Column("product_type_id")]
        public int ProductTypeId { get; set; }
    }
}
