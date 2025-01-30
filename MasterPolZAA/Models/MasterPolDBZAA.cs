using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MasterPolZAA.Models
{
    public partial class MasterPolDBZAA : DbContext
    {
        public MasterPolDBZAA()
            : base("name=MasterPolDBZAA3")
        {
        }

        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<PartnerProduct> PartnerProduct { get; set; }
        public virtual DbSet<PartnerType> PartnerType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Partner>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Partner>()
                .HasMany(e => e.PartnerProduct)
                .WithOptional(e => e.Partner)
                .HasForeignKey(e => e.PartnerId);

            modelBuilder.Entity<PartnerType>()
                .HasMany(e => e.Partner)
                .WithOptional(e => e.PartnerType)
                .HasForeignKey(e => e.PartnerTypeId);

            modelBuilder.Entity<Product>()
                .Property(e => e.Scu)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .HasMany(e => e.PartnerProduct)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<ProductType>()
                .HasMany(e => e.Product)
                .WithOptional(e => e.ProductType)
                .HasForeignKey(e => e.ProductTypeId);
        }
    }
}
