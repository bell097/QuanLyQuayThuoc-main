namespace QuanLyQuayThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [Key]
        public int detailOr_id { get; set; }

        [StringLength(15)]
        public string product_id { get; set; }

        public int? order_id { get; set; }

        public double? unitPriceSale { get; set; }

        public int? quantitySale { get; set; }

        public virtual Order Order { get; set; }
    }
}
