using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Shopper.Domain;

namespace Shopper.DataAccess.Context
{
    public class ShopperContext : DbContext
    {
        public ShopperContext() : base("name=ShopperContext")
        {
            {
                //InitializeDatabase();
                //Database.SetInitializer(new CreateDatabaseIfNotExists<ShopperContext>());
                //Database.SetInitializer<SchoolDBContext>(new CreateDatabaseIfNotExists<SchoolDBContext>());

                //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseIfModelChanges<SchoolDBContext>());
                //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
                //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
                Database.SetInitializer(new DataContextInitializer());

            }
        }

        //protected virtual void InitializeDatabase()
        //{
        //    if (!Database.Exists())
        //    {
        //        Database.Initialize(true);
        //        new DataContextInitializer().Seed(this);
        //    }
        //}

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.ShoppingCarts);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Inventories);

            base.OnModelCreating(modelBuilder);
        }
    }
}
