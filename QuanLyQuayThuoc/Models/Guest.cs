namespace QuanLyQuayThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Guest")]
    public partial class Guest
    {
        [Key]
        public int guest_id { get; set; }

        [StringLength(15)]
        public string phone { get; set; }

        [StringLength(50)]
        public string guest_name { get; set; }
    }
}
