using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("voucher")]
    public class Voucher : Base
    {
        [Column("code")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string Code { get; set; }
        
        [Column("discount_percent")]
        public double? DiscountPercent { get; set; }
        
        [Column("predefined_discount")]
        public decimal? PredefinedDiscount { get; set; }
        
        [Column("balance")]
        public decimal? Balance { get; set; }
        
        [Column("currency")]
        [StringLength(3, ErrorMessage = "Name can't be longer than 3 characters")]
        public string Currency { get; set; }
        
        [Required]
        [Column("begin_date")]
        public DateTime BeginDate { get; set; }
        
        [Column("end_date")]
        public DateTime? EndDate { get; set; }
        
        [Column("country")]
        [StringLength(150, ErrorMessage = "Name can't be longer than 150 characters")]
        public string Country { get; set; }
        
        [Required]
        [Column("voucher_type")]
        [ForeignKey(nameof(VoucherTypes))]
        public int VoucherType { get; set; }

        public virtual VoucherType VoucherTypes { get; set; }
        
        [Required]
        [Column("one_time")]
        public bool OneTime { get; set; }
        
        [Column("product_id")]
        [StringLength(200, ErrorMessage = "Name can't be longer than 200 characters")]
        public string ProductId { get; set; }
        
        [Column("product_discount_quantity")]
        public int? ProductDiscountQuantity { get; set; }
        
        [Column("author")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Author { get; set; }
        
        [Column("product_group_id")]
        public int? ProductGroupId { get; set; }
       
        [Column("shipping_price")]
        public decimal? ShippingPrice { get; set; }
    }
}
