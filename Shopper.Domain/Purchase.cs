namespace Shopper.Domain
{
    public abstract class Purchase
    {
        public int PurchaseId { get; set; }
        public abstract ShoppingCart CustomerPurchase(int customerId);
    }
}