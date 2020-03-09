using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("voucher_rule")]
    public class VoucherRule : Base
    {
        [Required]
        [Column("voucher_id")]
        public int VoucherId { get; set; }
       
        [Required]
        [Column("rule_type")]
        public int RuleType { get; set; }
       
        [Column("condition")]
        public int? Condition { get; set; }
       
        [Column("dependency_products")]
        [StringLength(250, ErrorMessage = "Name can't be longer than 250 characters")]
        public string DependencyProducts { get; set; }
       
        [Column("dependency_products_quantities")]
        [StringLength(250, ErrorMessage = "Name can't be longer than 250 characters")]
        public string DependencyProductsQuantities { get; set; }
    }
}
