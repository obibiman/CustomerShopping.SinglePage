using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopper.DataAccess.Context;

namespace Shopper.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ShopperContext context = new ShopperContext())
            {
                var numrec = context.Inventories.Count();
            }
        }
    }
}
