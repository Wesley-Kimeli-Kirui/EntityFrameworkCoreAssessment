using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assessmet4.Models;


namespace Assessmet4.Connection
{
    public class AppDbContext : DbContext
    {
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Shipments> Shipments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-BVFIMS7; Initial Catalog = EcommerceDatabase; User ID = sa; Password= 63143679; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId);

            modelBuilder.Entity<Orders>()
                .HasOne(o => o.Product)
                .WithMany(p => p.Orders)
                .HasForeignKey(o => o.ProductId);

            modelBuilder.Entity<Orders>()
                .HasOne(o => o.Shipment)
                .WithMany(s => s.Orders)
                .HasForeignKey(o => o.ShipmentId);

            modelBuilder.Entity<Orders>()
                .HasOne(o => o.Payment)
                .WithMany(p => p.Orders)
                .HasForeignKey(o => o.PaymentId);

            // modelBuilder.Entity<Shipments>()
            //     .HasOne(s => s.Orders)
            //     .WithOne(o => o.Shipment)
            //     .HasForeignKey<Shipments>(s => s.OrderId);


            modelBuilder.Entity<User>()
                .HasOne(u => u.Cart)
                .WithOne(c => c.User)
                .HasForeignKey<Cart>(c => c.UserId);
        }
    }
}
