using System.Data.Entity;
using Shopper.DataAccess.Seeding;
using Shopper.Domain;

namespace Shopper.DataAccess.Context
{
    public class ShopperContext : DbContext
    {
        public ShopperContext() : base("name=ShopperContext")
        {
            {
                Database.SetInitializer(new DataContextInitializer());
            }
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasRequired(e => e.ShoppingCart);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Inventories);
        }
    }
}
