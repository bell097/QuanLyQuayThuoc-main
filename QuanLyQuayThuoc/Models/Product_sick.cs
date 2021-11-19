namespace QuanLyQuayThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product_sick
    {
        [Key]
        public int product_sick_id { get; set; }

        [StringLength(15)]
        public string product_id { get; set; }

        public int? sick_id { get; set; }

        public virtual Product Product { get; set; }

        public virtual Sick Sick { get; set; }
    }
}
