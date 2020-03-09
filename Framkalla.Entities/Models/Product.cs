using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("product")]
    public class Product : Base
    {
        [Required]
        [Column("pr_agency_id")]
        [ForeignKey(nameof(PrintAgency))]
        public int PrintAgencyId { get; set; }

        public virtual PrintAgency PrintAgency { get; set; }
        
        [Required]
        [Column("product_type_id")]
        [ForeignKey(nameof(ProductType))]
        public int ProductTypeId { get; set; }

        public virtual ProductType ProductType { get; set; }
       
        [Required]
        [Column("price")]
        public decimal Price { get; set; }
       
        [Required]
        [Column("shipping_price")]
        public decimal ShippingPrice { get; set; }
        
        [Required]
        [Column("currency")]
        [StringLength(3, ErrorMessage = "Name can't be longer than 3 characters")]
        public string Currency { get; set; }
       
        [Required]
        [Column("cost_price")]
        public decimal CostPrice { get; set; }
        
        [Required]
        [Column("handling_price")]
        public decimal HandlingPrice { get; set; }
       
        [Required]
        [Column("is_published")]
        public bool IsPublished { get; set; }
        
        [Column("papersize")]
        [ForeignKey(nameof(PaperFamily))]
        public int? Papersize { get; set; }

        public virtual PaperFamily PaperFamily { get; set; }
        
        [Column("is_published_android")]
        public bool? IsPublishedAndroid { get; set; }
    }
}
