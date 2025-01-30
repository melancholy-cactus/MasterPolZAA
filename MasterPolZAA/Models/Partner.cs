using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using MasterPolZAA.Services;

namespace MasterPolZAA.Models
{


    [Table("Partner")]
    public partial class Partner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partner()
        {
            PartnerProduct = new HashSet<PartnerProduct>();
        }

        [Key]
        public int IdPartner { get; set; }

        public int? PartnerTypeId { get; set; }

        [StringLength(150)]
        public string PartnerName { get; set; }

        [StringLength(150)]
        public string Ceo { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(150)]
        public string Phone { get; set; }

        [StringLength(150)]
        public string Address { get; set; }

        [StringLength(150)]
        public string TaxpayerNumber { get; set; }

        public int? Rating { get; set; }

        public virtual PartnerType PartnerType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerProduct> PartnerProduct { get; set; }

        private double GetAmount()
        {
            double sum = 0;
            foreach (PartnerProduct partnerProduct in PartnerProduct)
            {
                sum += partnerProduct.Amount;
            }
            return sum;
        }

        public bool isNew()
        {
            return IdPartner == 0;
        }

        public int Discount
        {
            get
            {
                double amount = GetAmount();
                return DiscountManager.CalculateDiscount(amount);
            }

        }
    }
}
