using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("product_type_group")]
    public class ProductGroup : Base
    {
        [Required]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [Column("description")]
        public string Description { get; set; }

        [Column("image_id")]
        public int? ImageId { get; set; }

        [Required]
        [Column("select_position")]
        public int SelectPosition { get; set; }

        [Required]
        [Column("label_color")]
        [StringLength(10, ErrorMessage = "Name can't be longer than 10 characters")]
        public string LabelColor { get; set; }

        [Required]
        [Column("headline")]
        public string HeadLine { get; set; }

        [Column("processing_info")]
        public string ProcessingInfo { get; set; }

        [Column("group_type")]
        public int? GroupType { get; set; }

        [Column("workflow")]
        [ForeignKey(nameof(WorkFlow))] 
        public int? WorkFlowId { get; set; }

        public virtual Workflow WorkFlow { get; set; }

        [Column("jpeg_quality")]
        public int? JpegQuality { get; set; }

        [Column("priority_specification")]
        [StringLength(30, ErrorMessage = "Name can't be longer than 30 characters")]
        public string PrioritySpecification { get; set; }

    }
}
