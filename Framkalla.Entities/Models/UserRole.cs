using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("user_role")]
    public class UserRole : Base
    {
        [Required]
        [Column("role")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Role { get; set; }
    }
}
