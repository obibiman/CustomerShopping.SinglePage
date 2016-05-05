using System;
using System.Collections.Generic;

namespace Shopper.Domain
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }
        public virtual ICollection<Inventory> Purchases { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}