using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("product_type_background_image")]
    public class ProductTypeBackgroundImage : Base
    {
        [Required]
        [Column("product_id")]
        [ForeignKey(nameof(ProductType))]
        public int ProductId { get; set; }

        public virtual ProductType ProductType { get; set; }
        
        [Required]
        [Column("image_url")]
        [StringLength(2083, ErrorMessage = "Name can't be longer than 2083 characters")]
        public string ImageUrl { get; set; }
        
        [Required]
        [Column("region")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Region { get; set; }
        
        [Required]
        [Column("target")]
        public int Target { get; set; }
        
        [Required]
        [Column("area_x")]
        public int AreaX { get; set; }
        
        [Required]
        [Column("area_y")]
        public int AreaY { get; set; }
        
        [Required]
        [Column("area_width")]
        public int AreaWidth { get; set; }
        
        [Required]
        [Column("area_height")]
        public int AreaHeight { get; set; }
        
        [Required]
        [Column("select_position")]
        public int SelectPosition { get; set; }
    }
}
