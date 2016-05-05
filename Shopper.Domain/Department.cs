using System.Collections.Generic;

namespace Shopper.Domain
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public virtual ICollection<Inventory>  Inventories { get; set; }
    }
}