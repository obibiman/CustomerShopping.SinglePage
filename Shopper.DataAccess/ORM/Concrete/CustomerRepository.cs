using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using Shopper.DataAccess.Context;
using Shopper.DataAccess.SqlServer.ORM.Interfaces;
using Shopper.Domain;

namespace Shopper.DataAccess.SqlServer.ORM.Concrete
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly ShopperContext _context;
        public CustomerRepository(ShopperContext context)
        {
            _context = context;
        }

        public Customer Get(Expression<Func<Customer, bool>> predicate)
        {
            return _context.Customers.Where(predicate).SingleOrDefault();
        }

        public Customer GetById(int Id)
        {
            return _context.Customers.SingleOrDefault(y=>y.CustomerId==Id);
        }

        public IEnumerable<Customer> GetAll(Expression<Func<Customer, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return _context.Customers.Where(predicate).ToList();
            }
            return new List<Customer>();
        }

        public void Add(Customer entity)
        {
            _context.Customers.Add(entity);
        }

        public void Update(Customer entity)
        {
            var existingEntity = GetById(entity.CustomerId);
            if (existingEntity == null)
            {
                return;
            }
            _context.Customers.AddOrUpdate(entity);
        }

        public void Delete(Customer entity)
        {
            _context.Customers.Remove(entity);
        }

        public long Count()
        {
            return _context.Customers.Count();
        }

        public void AddRange(IEnumerable<Customer> entities)
        {
            _context.Customers.AddRange(entities);
        }

        public void RemoveRange(IEnumerable<Customer> entities)
        {
            _context.Customers.RemoveRange(entities);
        }
    }
}