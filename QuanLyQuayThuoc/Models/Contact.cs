namespace QuanLyQuayThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact")]
    public partial class Contact
    {
        [Key]
        public int contact_id { get; set; }

        [Column(TypeName = "ntext")]
        public string contact_content { get; set; }

        public int? contact_status { get; set; }
    }
}
