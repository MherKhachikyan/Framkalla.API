using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("social_account")]
    public class SocialAccount : Base
    {
        [Required]
        [Column("user_id")]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public virtual User User { get; set; }
       
        [Required]
        [Column("type")]
        [ForeignKey(nameof(SocialAccountType))]
        public int Type { get; set; }

        public virtual SocialAccountType SocialAccountType { get; set; }
      
        [Column("email")]
        [StringLength(300, ErrorMessage = "Name can't be longer than 300 characters")]
        public string Email { get; set; }
       
        [Column("profile_picture")]
        [StringLength(2083, ErrorMessage = "Name can't be longer than 2083 characters")]
        public string ProfilePicture { get; set; }
       
        [Column("full_name")]
        [StringLength(255, ErrorMessage = "Name can't be longer than 255 characters")]
        public string FullName { get; set; }
       
        [Column("username")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string Username { get; set; }
       
        [Required]
        [Column("soc_id")]
        public long SocId { get; set; }
    }
}
