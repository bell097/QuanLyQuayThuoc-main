namespace QuanLyQuayThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockIn")]
    public partial class StockIn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockIn()
        {
            StockinDetails = new HashSet<StockinDetail>();
        }

        [Key]
        public int stockin_id { get; set; }

        public int dis_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public double total { get; set; }

        public virtual Distributor Distributor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockinDetail> StockinDetails { get; set; }
    }
}
