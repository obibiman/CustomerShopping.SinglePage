using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopper.DataAccess.Context;

namespace Shopper.DataAccess.Seeding
{
    public class DataContextInitializer : DropCreateDatabaseIfModelChanges<ShopperContext>
    {
        protected override void Seed(ShopperContext context)
        {
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
