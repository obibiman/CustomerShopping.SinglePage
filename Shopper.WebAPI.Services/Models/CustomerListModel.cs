using Shopper.Domain;

namespace Shopper.WebAPI.Services.Models
{
    public class CustomerListModel
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}