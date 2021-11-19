namespace QuanLyQuayThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            BillDetails = new HashSet<BillDetail>();
            Product_sick = new HashSet<Product_sick>();
            StockinDetails = new HashSet<StockinDetail>();
        }

        [Key]
        [StringLength(15)]
        public string product_id { get; set; }

        [Required]
        [StringLength(150)]
        public string product_name { get; set; }

        public int brand_id { get; set; }

        public int origin_id { get; set; }

        public int smallcategory_id { get; set; }

        [StringLength(50)]
        public string product_image { get; set; }

        [StringLength(25)]
        public string product_packing { get; set; }

        [StringLength(20)]
        public string product_format { get; set; }

        [StringLength(100)]
        public string product_user { get; set; }

        [Column(TypeName = "ntext")]
        public string product_uses { get; set; }

        [StringLength(150)]
        public string product_treatment { get; set; }

        [StringLength(15)]
        public string product_number { get; set; }

        [StringLength(100)]
        public string product_warning { get; set; }

        [Column(TypeName = "ntext")]
        public string product_description { get; set; }

        [StringLength(5)]
        public string prescription_drugs { get; set; }

        public double? product_imprice { get; set; }

        public double? product_saleprice { get; set; }

        public double? product_retailprice { get; set; }

        public int? product_status { get; set; }

        public int? product_quantity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetails { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual Origin Origin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_sick> Product_sick { get; set; }

        public virtual SmallCategory SmallCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockinDetail> StockinDetails { get; set; }
    }
}
