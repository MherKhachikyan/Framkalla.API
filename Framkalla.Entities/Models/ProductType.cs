using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("product_type")]
    public class ProductType : Base
    {
        [Required]
        [Column("name")]
        public string Name { get; set; }
        
        [Required]
        [Column("is_published")]
        public bool IsPublished { get; set; }
        
        [Required]
        [Column("single_image")]
        public bool SingleImage { get; set; }

        [Column("processing_info")]
        public string ProcessingInfoString { get; set; }

        [Required]
        [ForeignKey(nameof(Group))]
        [Column("product_group_id")]
        public int ProductGroupId { get; set; }

        public virtual ProductGroup Group { get; set; }

        [Column("has_preview")]
        public bool? HasPreview { get; set; }
        
        [StringLength(200)]
        [Column("product_id")]
        public string ProductId { get; set; }
        
        [Column("description")]
        public string Description { get; set; }
        
        [Column("thumbnail_url")]
        [StringLength(2083)]
        public string ThumbnailUrl { get; set; }
        
        [Column("select_position")]
        public int? SelectPosition { get; set; }
        
        [Column("tag")]
        [StringLength(50)]
        public string Tag { get; set; }
       
        [Required]
        [Column("is_published_android")]
        public bool IsPublishedAndroid { get; set; }
       
        [Required]
        [Column("background_type")]
        public int BackgroundType { get; set; }
     
        [Column("mandatory_accessory_id")]
        public int? MandatoryAccessoryId { get; set; }
      
        [Column("inventory_id")]
        public int? InventoryId { get; set; }
      
        [Column("mandatory_accessory_visible_in_cart")]
        public bool? MandatoryAccessoryVisibleInCart { get; set; }
    
        [Column("cover_image")]
        [ForeignKey(nameof(ProductImage))]
        public int? CoverImage { get; set; }

        public virtual ProductImage ProductImage { get; set; }
       
        [Column("tag_group_name")]
        public string TagGroupName { get; set; }
      
        [Column("catalog_description")]
        public string CatalogDescription { get; set; }
        
        [Column("iphone_url")]
        [StringLength(2083)]
        public string IphoneUrl { get; set; }
       
        [Column("google_product_category")]
        public string GoogleProductCategory { get; set; }
      
        [Column("api_processing_info")]
        public string ApiProcessingInfo { get; set; }
    }
}
