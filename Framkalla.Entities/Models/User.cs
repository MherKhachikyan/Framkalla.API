using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("user")]
    public class User : Base
    {
        [Column("name")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string Name { get; set; }
        
        [Column("last_name")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string LastName { get; set; }
        
        [Column("email")]
        [StringLength(255, ErrorMessage = "Name can't be longer than 255 characters")]
        public string Email { get; set; }
        
        [Column("password")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string Password { get; set; }
        
        [Column("country")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Country { get; set; }
        
        [Column("address")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string Address { get; set; }
        
        [Required]
        [Column("role")]
        public int Role { get; set; }
        
        [Column("temp_password")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string TempPassword { get; set; }
        
        [Column("profile_image")]
        [StringLength(2083, ErrorMessage = "Name can't be longer than 2083 characters")]
        public string ProfileImage { get; set; } 
        
        [Column("stripe_customer_id")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string StripeCustomerId { get; set; }
        
        [Column("stripe_card_id")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string StripeCardId { get; set; }
        
        [Column("account_confirmed")]
        public bool? AccountConfirmed { get; set; }
        
        [Column("birth_date")]
        public DateTime? BirthDate { get; set; }
        
        [Column("personal_voucher")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string PersonalVoucher { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("marketing_accepted")]
        public bool? MarketingAccepted { get; set; }
        
        [Column("privacy_accepted")]
        public bool? PrivacyAccepted { get; set; }
        
        [Column("marketing_accepted_date")]
        public DateTime? MarketingAcceptedDate { get; set; }
        
        [Column("privacy_accepted_date")]
        public DateTime? PrivacyAcceptedDate { get; set; }
        
        [Column("referral_id")]
        public int? ReferralId { get; set; }
       
        [Column("referrence_id")]
        public int? ReferrenceId { get; set; }
    }
}
