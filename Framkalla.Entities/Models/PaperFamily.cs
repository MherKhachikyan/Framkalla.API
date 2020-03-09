using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("paper_family")]
    public class PaperFamily : Base
    {
        [Required]
        [Column("paper_family1")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string PaperFamily1 { get; set; }
    }
}
