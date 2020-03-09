using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    public abstract class Base
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
    }
}
