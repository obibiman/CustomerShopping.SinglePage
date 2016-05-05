using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Shopper.Domain;

namespace Shopper.DataServices.Interfaces
{
    public interface IInventoryService
    {
        void Add(Inventory entity);
        IEnumerable<Inventory> GetAll(Expression<Func<Inventory, bool>> predicate = null);
        Inventory GetById(int Id);
        void Update(Inventory entity);
        void Delete(Inventory entity);
        long Count();
        void AddRange(IEnumerable<Inventory> entities);
        void RemoveRange(IEnumerable<Inventory> entities);
        void SaveChanges();
    }
}
