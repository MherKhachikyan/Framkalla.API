using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("social_account_type")]
    public class SocialAccountType : Base
    {
        [Required]
        [Column("type")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Type { get; set; }
    }
}
