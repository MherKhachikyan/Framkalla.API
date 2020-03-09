using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("print_agency")]
    public class PrintAgency : Base
    {
        [Required]
        [Column("company_name")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string CompanyName { get; set; }
       
        [Required]
        [Column("country")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string Country { get; set; }
       
        [Required]
        [Column("user_id")]
        public int UserId { get; set; }
       
        [Column("is_active")]
        public bool? IsActive { get; set; }
       
        [Column("has_API")]
        public bool? HasAPI { get; set; }
    }
}
