using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper.Domain
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
