using System;
using System.Net.Http.Headers;
using InventoryApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace InventoryApp.Data
{
    public class InventoryAppContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Marketplace> Marketplaces { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source= MSI\\SQLEXPRESS; Initial Catalog=InventoryAppData; User=sa; Password=test";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasMany(m => m.Marketplaces)
                .WithMany(p => p.Products)
                .UsingEntity<MarketplaceProduct>
                (mp=> mp.HasOne<Marketplace>().WithMany(), 
                    mp => mp.HasOne<Product>().WithMany())
                .Property(mp => mp.DateListed)
                .HasDefaultValueSql("getdate()");
            base.OnModelCreating(modelBuilder);
        }
    }
}
