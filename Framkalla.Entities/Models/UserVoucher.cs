using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("user_voucher")]
    public class UserVoucher : Base
    {
        [Column("user_id")]
        [ForeignKey(nameof(User))]
        public int? UserId { get; set; }

        public virtual User User { get; set; }
       
        [Column("voucher_id")]
        public int? VoucherId { get; set; }
        
        [Column("status")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Status { get; set; }
        
        [Column("used_date")]
        public DateTime? UsedDate { get; set; }
    }
}
