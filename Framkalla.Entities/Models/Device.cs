using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("device")]
    public class Device : Base
    {
        [Required]
        [Column("device_id")]
        [StringLength(255, ErrorMessage = "Name can't be longer than 255 characters")]
        public string DeviceId { get; set; }
      
        [Column("device_token")]
        [StringLength(255, ErrorMessage = "Name can't be longer than 255 characters")]
        public string DeviceToken { get; set; }
       
        [Required]
        [Column("date")]
        public DateTime Date { get; set; }
      
        [Required]
        [Column("os")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Os { get; set; }
       
        [Column("app_version")]
        [StringLength(10, ErrorMessage = "Name can't be longer than 10 characters")]
        public string AppVersion { get; set; }
    }
}
