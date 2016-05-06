using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using Shopper.DataAccess.Context;
using Shopper.DataAccess.DataTier.Repo.Interfaces;
using Shopper.Domain;

namespace Shopper.DataAccess.DataTier.Repo.Concrete
{
    public class DepartmentRepository : IRepository<Department>
    {
        private readonly ShopperContext _context;
        public DepartmentRepository(ShopperContext context)
        {
            _context = context;
        }

        public Department Get(Expression<Func<Department, bool>> predicate)
        {
            return _context.Departments.Where(predicate).SingleOrDefault();
        }

        public Department GetById(int Id)
        {
            return _context.Departments.SingleOrDefault(y => y.DepartmentId == Id);
        }

        public IEnumerable<Department> GetAll(Expression<Func<Department, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return _context.Departments.Where(predicate).ToList();
            }
            return new List<Department>();
        }

        public void Add(Department entity)
        {
            _context.Departments.Add(entity);
        }

        public void Update(Department entity)
        {
            var existingEntity = GetById(entity.DepartmentId);
            if (existingEntity == null)
            {
                return;
            }
            _context.Departments.AddOrUpdate(entity);
        }

        public void Delete(Department entity)
        {
            _context.Departments.Remove(entity);
        }

        public long Count()
        {
            return _context.Customers.Count();
        }

        public void AddRange(IEnumerable<Department> entities)
        {
            _context.Departments.AddRange(entities);
        }

        public void RemoveRange(IEnumerable<Department> entities)
        {
            _context.Departments.RemoveRange(entities);
        }
    }
}