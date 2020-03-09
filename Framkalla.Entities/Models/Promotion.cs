using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("promotion")]
    public class Promotion : Base
    {
        [Required]
        [Column("url")]
        [StringLength(2083, ErrorMessage = "Name can't be longer than 2083 characters")]
        public string Url { get; set; }
       
        [Required]
        [Column("target")]
        [StringLength(10, ErrorMessage = "Name can't be longer than 10 characters")]
        public string Target { get; set; }
       
        [Required]
        [Column("image")]
        [StringLength(2083, ErrorMessage = "Name can't be longer than 2083 characters")]
        public string Image { get; set; }
       
        [Column("country")]
        [StringLength(150, ErrorMessage = "Name can't be longer than 150 characters")]
        public string Country { get; set; }
        
        [Column("language")]
        [StringLength(200, ErrorMessage = "Name can't be longer than 200 characters")]
        public string Language { get; set; }
        
        [Column("max_version")]
        [StringLength(25, ErrorMessage = "Name can't be longer than 25 characters")]
        public string MaxVersion { get; set; }
    }
}
