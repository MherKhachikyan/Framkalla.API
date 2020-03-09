using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("product_group_image")]
    public class ProductGroupImage : Base
    {
        [Required]
        [Column("url")]
        public string Url { get; set; }

        [Required]
        [Column("product_type_group_id")]
        [ForeignKey(nameof(ProductGroup))]
        public int ProductTypeGroupId { get; set; }

        public virtual ProductGroup ProductGroup { get; set; }
    }
}
