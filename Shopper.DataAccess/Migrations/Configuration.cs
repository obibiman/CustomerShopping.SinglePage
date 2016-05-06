using System.Collections.Generic;
using Shopper.Domain;

namespace Shopper.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.ShopperContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context.ShopperContext context)
        {
            var list = new List<Department>
            {
                new Department
                {
                    DepartmentName = "Produce",
                    Inventories = new List<Inventory>
                    {
                        new Inventory { ItemName = "Watermelons", ItemDescription = "Watermelon", Manufacturer = "Con Agra", Price = 3.56m, Supplier = "Brazoria Farms", UnitsInStock = 234, RetailDispense = RetailDispense.Individual},
                        new Inventory { ItemName = "Peanuts", ItemDescription = "Dry roasted peanuts", Manufacturer = "Carter nuts of Georgia", Price = 1.98m, Supplier = "Dale Distributing", UnitsInStock = 500, RetailDispense = RetailDispense.Individual}
                    }
                },
                new Department
                {
                    DepartmentName = "Dairy",
                    Inventories = new List<Inventory>
                    {
                        new Inventory { ItemName = "WateGreek Yogurt", ItemDescription = "Yogurt with fruits", Manufacturer = "Samuels dairy", Price = 3.56m, Supplier = "Brazoria Farms", UnitsInStock = 234, RetailDispense = RetailDispense.Individual},
                        new Inventory { ItemName = "1 gallon whole milk", ItemDescription = "Ben and Jerry's lowfat yogurt", Manufacturer = "Ben and Jerrys", Price = 1.98m, Supplier = "Dale Distributing", UnitsInStock = 500, RetailDispense = RetailDispense.Individual}
                    }
                }
            };


            var custs = new List<Customer>
            {
                new Customer {FirstName = "Mike", LastName = "Danforth", ShoppingCarts = new List<ShoppingCart>()},
                 new Customer {FirstName = "Mary", LastName = "Lane", ShoppingCarts = new List<ShoppingCart>()},
                  new Customer {FirstName = "Sid", LastName = "O'Reilly", ShoppingCarts = new List<ShoppingCart>()}
            };

            custs.ForEach(m =>
            {
                context.Customers.AddOrUpdate(m);
            });
            list.ForEach(m =>
            {
                context.Departments.AddOrUpdate(m);
            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
