using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("user_token")]
    public class UserToken : Base
    {
        [Required]
        [Column("user_id")]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public virtual User User { get; set; }
      
        [Column("social_account_id")]
        public int? SocialAccountId { get; set; }
       
        [Required]
        [Column("token")]
        [StringLength(255, ErrorMessage = "Name can't be longer than 255 characters")]
        public string Token { get; set; }
    }
}
