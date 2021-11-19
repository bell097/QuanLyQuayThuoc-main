namespace QuanLyQuayThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockinDetail")]
    public partial class StockinDetail
    {
        [Key]
        public int stockindetail_id { get; set; }

        public int stockin_id { get; set; }

        [Required]
        [StringLength(15)]
        public string product_id { get; set; }

        public int stockin_quantity { get; set; }

        public double impirce { get; set; }

        public virtual Product Product { get; set; }

        public virtual StockIn StockIn { get; set; }
    }
}
