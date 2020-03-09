using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("user_device")]
    public class UserDevice : Base
    {
        [Required]
        [Column("user_id")]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public virtual User User { get; set; }
       
        [Required]
        [Column("device_id")]
        [ForeignKey(nameof(Device))]
        public int DeviceId { get; set; }

        public virtual Device Device { get; set; }
       
        [Required]
        [Column("date")]
        public DateTime Date { get; set; }
       
        [Column("access_token")]
        [StringLength(500, ErrorMessage = "Name can't be longer than 500 characters")]
        public string AccessToken { get; set; }
        
        [Column("status")]
        [StringLength(30, ErrorMessage = "Name can't be longer than 30 characters")]
        public string Status { get; set; }
    }
}
