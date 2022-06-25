using IMS.CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Plugins.EFCore
{
    public class IMSContext : DbContext
    {
        public IMSContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<InventoryTransaction> InventoryTransactions { get; set; }
        public DbSet<ProductTransaction> ProductTransactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //build relationships
            modelBuilder.Entity<ProductInventory>()
                .HasKey(pi => new { pi.ProductId,pi.InventoryId });
            modelBuilder.Entity<ProductInventory>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.ProductInventories)
                .HasForeignKey(pi => pi.ProductId);
            modelBuilder.Entity<ProductInventory>()
                .HasOne(pi => pi.Inventory)
                .WithMany(i => i.ProductInventories)
                .HasForeignKey(pi => pi.InventoryId);

            //seeding data
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory { InventoryId = 1, InventoryName = "Gas Engine", Price = 1000, Quantity = 1 },
                new Inventory { InventoryId = 2, InventoryName = "Body", Price = 400, Quantity = 1 },
                new Inventory { InventoryId = 3, InventoryName = "Wheel", Price = 100, Quantity = 4 },
                new Inventory { InventoryId = 4, InventoryName = "Seat", Price = 50, Quantity = 5 },
                new Inventory { InventoryId = 5, InventoryName = "Electtric Engine", Price = 8000, Quantity = 2 },
                new Inventory { InventoryId = 6, InventoryName = "Battery", Price = 400, Quantity = 5 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Gas Car", Price = 1000, Quantity = 1 },
                new Product { ProductId = 2, ProductName = "Electric Car", Price = 400, Quantity = 1 }
            );

            modelBuilder.Entity<ProductInventory>().HasData(
                new ProductInventory { ProductId = 2, InventoryId = 5, InventoryQuantity = 1 },
                new ProductInventory { ProductId = 2, InventoryId = 2, InventoryQuantity = 1 },
                new ProductInventory { ProductId = 2, InventoryId = 3, InventoryQuantity = 4 },
                new ProductInventory { ProductId = 2, InventoryId = 4, InventoryQuantity = 5 },
                new ProductInventory { ProductId = 2, InventoryId = 6, InventoryQuantity = 1 }
                );
        }
    }
}
