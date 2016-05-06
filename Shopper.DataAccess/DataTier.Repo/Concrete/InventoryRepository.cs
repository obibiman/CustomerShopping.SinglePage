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
    public class InventoryRepository : IRepository<Inventory>
    {
        private readonly ShopperContext _context;
        public InventoryRepository(ShopperContext context)
        {
            _context = context;
        }

        public Inventory Get(Expression<Func<Inventory, bool>> predicate)
        {
            return _context.Inventories.Where(predicate).SingleOrDefault();
        }

        public Inventory GetById(int Id)
        {
            return _context.Inventories.SingleOrDefault(y => y.InventoryId == Id);
        }

        public IEnumerable<Inventory> GetAll(Expression<Func<Inventory, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return _context.Inventories.Where(predicate).ToList();
            }
            return new List<Inventory>();
        }

        public void Add(Inventory entity)
        {
            _context.Inventories.Add(entity);
        }

        public void Update(Inventory entity)
        {
            var existingEntity = GetById(entity.InventoryId);
            if (existingEntity == null)
            {
                return;
            }
            _context.Inventories.AddOrUpdate(entity);
        }

        public void Delete(Inventory entity)
        {
            _context.Inventories.Remove(entity);
        }

        public long Count()
        {
            return _context.Inventories.Count();
        }

        public void AddRange(IEnumerable<Inventory> entities)
        {
            _context.Inventories.AddRange(entities);
        }

        public void RemoveRange(IEnumerable<Inventory> entities)
        {
            _context.Inventories.RemoveRange(entities);
        }
    }
}