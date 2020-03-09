using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("workflow")]
    public class Workflow : Base
    {
        [Required]
        [Column("workflow_specifier")]
        public int WorkflowSpecifier { get; set; }
       
        [Column("description")]
        [StringLength(200, ErrorMessage = "Name can't be longer than 200 characters")]
        public string Description { get; set; }
    }
}
