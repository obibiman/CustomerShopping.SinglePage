using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Shopper.Domain;

namespace Shopper.DataServices.Interfaces
{
    public interface ICustomerService
    {
        void Add(Customer entity);
        IEnumerable<Customer> GetAll(Expression<Func<Customer, bool>> predicate = null);
        Customer GetById(int Id);
        void Update(Customer entity);
        void Delete(Customer entity);
        long Count();
        void AddRange(IEnumerable<Customer> entities);
        void RemoveRange(IEnumerable<Customer> entities);
        void SaveChanges();
    }
}