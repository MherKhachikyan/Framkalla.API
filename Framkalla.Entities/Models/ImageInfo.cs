using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Framkalla.Entities.Models
{
    [Table("image_info")]
    public class ImageInfo : Base
    {
        [Required]
        [Column("order_item_id")]
        [ForeignKey(nameof(OrderItem))]
        public int OrderItemId { get; set; }

        public virtual OrderItem OrderItem { get; set; }
        
        [Column("local_uri_ori")]
        [StringLength(2083, ErrorMessage = "Name can't be longer than 2083 characters")]
        public string LocalUriOri { get; set; }
       
        [Column("local_uri_fin")]
        [StringLength(2083, ErrorMessage = "Name can't be longer than 2083 characters")]
        public string LocalUriFin { get; set; }
       
        [Column("source_uri")]
        [StringLength(2083, ErrorMessage = "Name can't be longer than 2083 characters")]
        public string SourceUri { get; set; }
        
        [Column("metadata")]
        public string Metadata { get; set; }
        
        [Column("edit_info")]
        [StringLength(200, ErrorMessage = "Name can't be longer than 200 characters")]
        public string EditInfo { get; set; }
    }
}
