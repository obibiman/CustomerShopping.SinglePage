using System;
using Shopper.Domain;

namespace Shopper.DataAccess.SqlServer.ORM.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Customer> CustomerRepository { get; }
        IRepository<Department> DepartmentRepository { get; }
        IRepository<Inventory> InventoryRepository { get; }
        int Complete();
    }
}