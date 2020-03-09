using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("order")]
    public class Order : Base
    {
        [Required]
        [Column("user_id")]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public virtual User User { get; set; }

        [Column("country")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Country { get; set; }
        
        [Column("date")]
        public DateTime? Date { get; set; }
        
        [Column("total_cost")]
        public decimal? TotalCost { get; set; }
        
        [Column("tax")]
        public decimal? Tax { get; set; }
        
        [Column("comment")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string Comment { get; set; }
        
        [Required]
        [Column("status")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Status { get; set; }
        
        [Column("receipts_info")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string ReceiptsInfo { get; set; }
        
        [Column("device_id")]
        [ForeignKey(nameof(Device))]
        public int? DeviceId { get; set; }

        public virtual Device Device { get; set; }
        
        [Column("address")]
        [StringLength(70, ErrorMessage = "Name can't be longer than 70 characters")]
        public string Address { get; set; }
        
        [Column("delivery_email")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string DeliveryEmail { get; set; }
        
        [Column("city")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string City { get; set; }
        
        [Column("customer_name")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string CustomerName { get; set; }
        
        [Column("customer_last_name")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string CustomerLastName { get; set; }
        
        [Column("address_line_2")]
        [StringLength(40, ErrorMessage = "Name can't be longer than 40 characters")]
        public string AddressLine2 { get; set; }
        
        [Column("postal_code")]
        [StringLength(30, ErrorMessage = "Name can't be longer than 30 characters")]
        public string PostalCode { get; set; }
        
        [Column("telephone")]
        [StringLength(30, ErrorMessage = "Name can't be longer than 30 characters")]
        public string Telephone { get; set; }
        
        [Column("voucher")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Voucher { get; set; }
        
        [Column("last_request_locale")]
        [StringLength(5, ErrorMessage = "Name can't be longer than 5 characters")]
        public string LastRequestLocale { get; set; }
        
        [Column("upload_status")]
        public bool? UploadStatus { get; set; }
        
        [Column("is_activated")]
        public bool? IsActivated { get; set; }
        
        [Column("is_created")]
        public bool? IsCreated { get; set; }
        
        [Column("sellable_cost_price")]
        public decimal? SellableCostPrice { get; set; }
        
        [Column("freight_cost")]
        public decimal? FreightCost { get; set; }
        
        [Column("cost_price")]
        public decimal? CostPrice { get; set; }
        
        [Column("order_currency")]
        [StringLength(3, ErrorMessage = "Name can't be longer than 3 characters")]
        public string OrderCurrency { get; set; }
        
        [Column("order_freight_type")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string OrderFreightType { get; set; }
        
        [Column("klarna_order_id")]
        [StringLength(255, ErrorMessage = "Name can't be longer than 255 characters")]
        public string KlarnaOrderId { get; set; }
        
        [Column("upload_paused")]
        public bool? UploadPaused { get; set; }
        
        [Column("app_version")]
        [StringLength(10, ErrorMessage = "Name can't be longer than 10 characters")]
        public string AppVersion { get; set; }
        
        [Column("shipping_price")]
        public decimal? ShippingPrice { get; set; }
        
        [Column("state")]
        [StringLength(10, ErrorMessage = "Name can't be longer than 10 characters")]
        public string State { get; set; }
       
        [Column("image_silver_mismatch")]
        public bool? ImageSilverMismatch { get; set; }

    }
}
