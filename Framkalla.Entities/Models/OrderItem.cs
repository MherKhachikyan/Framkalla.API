using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("order_item")]
    public class OrderItem : Base
    {
        [Column("order_id")]
        public int? OrderId { get; set; }
       
        [Column("print_agency_id")]
        public int? PrintAgencyId { get; set; }

        [Column("product_id")]
        [ForeignKey(nameof(ProductType))]
        public int? ProductId { get; set; }

        public virtual ProductType ProductType { get; set; }

        [Column("pr_agency_comment")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string PrAgencyComment { get; set; }
        
        [Column("status")]
        [StringLength(30, ErrorMessage = "Name can't be longer than 30 characters")]
        public string Status { get; set; }
       
        [Column("date")]
        public DateTime? Date { get; set; }
        
        [Column("filter_type")]
        public int? FilterType { get; set; }
        
        [Column("final_destination_uri")]
        public string FinalDestinationUri { get; set; }
       
        [Column("print_date")]
        public DateTime? PrintDate { get; set; }
       
        [Column("quantity")]
        public int? Quantity { get; set; }
       
        [Column("ushipped_dateser")]
        public DateTime? ShippedDate { get; set; }
       
        [Column("notified")]
        public bool? Notified { get; set; }
       
        [Column("order_set")]
        public int? OrderSet { get; set; }
       
        [Column("processing_info")]
        public string ProcessingInfo { get; set; }
       
        [Column("reorder_count")]
        public int? ReorderCount { get; set; }
       
        [Column("invoiced_count")]
        public int? InvoicedCount { get; set; }
        
        [Column("is_uploaded")]
        public bool? IsUploaded { get; set; }
       
        [Column("gift_emailed")]
        public bool? GiftEmailed { get; set; }
       
        [Column("tracking_code")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string TrackingCode { get; set; }
       
        [Column("is_delivered")]
        public bool? IsDelivered { get; set; }
      
        [Column("thumbnail_final_destionation_url")]
        [StringLength(2083, ErrorMessage = "Name can't be longer than 2083 characters")]
        public string ThumbnailFinalDestionationUrl { get; set; }
        
        [Column("order_item_relationship")]
        public int? OrderItemRelationship { get; set; }
      
        [Column("cost_price")]
        public decimal? CostPrice { get; set; }
       
        [Column("freight_type")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string FreightType { get; set; }
        
        [Column("report_date")]
        public DateTime? ReportDate { get; set; }
       
        [Column("sellable_product_id")]
        public int? SellableProductId { get; set; }
       
        [Column("sellable_product_cost_price")]
        public decimal? SellableProductCostPrice { get; set; }
       
        [Column("generated_voucher_code")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string GeneratedVoucherCode { get; set; }
       
        [Column("uploader_additional_info")]
        [StringLength(255, ErrorMessage = "Name can't be longer than 255 characters")]
        public string UploaderAdditionalInfo { get; set; }
       
        [Column("transaction_completed")]
        public bool? TransactionCompleted { get; set; }
        
        [Column("push_status")]
        [StringLength(9, ErrorMessage = "Name can't be longer than 9 characters")]
        public string PushStatus { get; set; }
        
        [Column("push_message")]
        public string PushMessage { get; set; }
      
        [Column("push_date")]
        public DateTime? PushDate { get; set; }
    }
}
