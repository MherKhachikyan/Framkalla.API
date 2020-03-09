using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("referral_rule")]
    public class ReferralRule : Base
    {
        [Required]
        [Column("country")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Country { get; set; }
       
        [Required]
        [Column("affects_group")]
        public int AffectsGroup { get; set; }
       
        [Column("percentage")]
        public int? Percentage { get; set; }
        
        [Column("amount")]
        public decimal? Amount { get; set; }
       
        [Column("currency")]
        [StringLength(4, ErrorMessage = "Name can't be longer than 4 characters")]
        public string Currency { get; set; }
    }
}
