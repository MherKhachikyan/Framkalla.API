using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("voucher_type")]
    public class VoucherType : Base
    {
        [Column("type")]
        [StringLength(20, ErrorMessage = "Name can't be longer than 20 characters")]
        public string Type { get; set; }
    }
}
