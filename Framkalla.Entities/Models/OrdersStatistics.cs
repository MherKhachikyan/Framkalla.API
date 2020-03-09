using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("orders_statistics")]
    public class OrdersStatistics : Base
    {
        [Required]
        [Column("Report_date")]
        public DateTime ReportDate { get; set; }
       
        [Required]
        [Column("user_device_id")]
        [StringLength(10, ErrorMessage = "Name can't be longer than 10 characters")]
        public string UserDeviceId { get; set; }
        
        [Required]
        [Column("wait_time")]
        public double WaitTime { get; set; }
       
        [Required]
        [Column("report_order_id")]
        public int ReportOrderId { get; set; }
    }
}
