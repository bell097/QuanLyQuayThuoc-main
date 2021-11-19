namespace QuanLyQuayThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sick")]
    public partial class Sick
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sick()
        {
            Product_sick = new HashSet<Product_sick>();
        }

        [Key]
        public int sick_id { get; set; }

        [Required]
        [StringLength(50)]
        public string sick_name { get; set; }

        [Column(TypeName = "ntext")]
        public string sick_content { get; set; }

        public int categorySick_id { get; set; }

        public virtual CategorySick CategorySick { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_sick> Product_sick { get; set; }
    }
}
