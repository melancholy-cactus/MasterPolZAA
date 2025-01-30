namespace MasterPolZAA.Models
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
            PartnerProduct = new HashSet<PartnerProduct>();
        }

        [Key]
        public int IdProduct { get; set; }

        public int? ProductTypeId { get; set; }

        [StringLength(150)]
        public string ProductName { get; set; }

        [StringLength(150)]
        public string Scu { get; set; }

        public double? MinimalCostForPartner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerProduct> PartnerProduct { get; set; }

        public virtual ProductType ProductType { get; set; }
    }
}
