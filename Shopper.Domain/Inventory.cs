namespace Shopper.Domain
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int DepartmentId { get; set; }
        public string ItemDescription { get; set; }
        public string ItemName { get; set; }
        public string Manufacturer { get; set; }
        public string Supplier { get; set; }
        public double UnitsInStock { get; set; }
        public RetailDispense RetailDispense { get; set; }
        public decimal Price { get; set; }
    }
}