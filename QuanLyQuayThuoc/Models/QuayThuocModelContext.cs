using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyQuayThuoc.Models
{
    public partial class QuayThuocModelContext : DbContext
    {
        public QuayThuocModelContext()
            : base("name=QuayThuocModelContext5")
        {
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategorySick> CategorySicks { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Distributor> Distributors { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Origin> Origins { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product_sick> Product_sick { get; set; }
        public virtual DbSet<Sick> Sicks { get; set; }
        public virtual DbSet<SmallCategory> SmallCategories { get; set; }
        public virtual DbSet<StockIn> StockIns { get; set; }
        public virtual DbSet<StockinDetail> StockinDetails { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>()
                .Property(e => e.cus_Phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .HasMany(e => e.BillDetails)
                .WithRequired(e => e.Bill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Brand>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Brand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.SmallCategories)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CategorySick>()
                .HasMany(e => e.Sicks)
                .WithRequired(e => e.CategorySick)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.cus_Phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Distributor>()
                .HasMany(e => e.StockIns)
                .WithRequired(e => e.Distributor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.fb_phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Origin>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Origin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.product_image)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.prescription_drugs)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.BillDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.StockinDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SmallCategory>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.SmallCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StockIn>()
                .HasMany(e => e.StockinDetails)
                .WithRequired(e => e.StockIn)
                .WillCascadeOnDelete(false);
        }
    }
}
