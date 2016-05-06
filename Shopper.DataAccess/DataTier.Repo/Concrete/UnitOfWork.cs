using Shopper.DataAccess.Context;
using Shopper.DataAccess.DataTier.Repo.Interfaces;
using Shopper.Domain;

namespace Shopper.DataAccess.DataTier.Repo.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShopperContext _context;

        public UnitOfWork(ShopperContext context)
        {
            _context = context;
            CustomerRepository = new CustomerRepository(_context);
            DepartmentRepository = new DepartmentRepository(_context);
            InventoryRepository = new InventoryRepository(_context);
        }

        public IRepository<Customer> CustomerRepository { get; }
        public IRepository<Department> DepartmentRepository { get; }
        public IRepository<Inventory> InventoryRepository { get; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}