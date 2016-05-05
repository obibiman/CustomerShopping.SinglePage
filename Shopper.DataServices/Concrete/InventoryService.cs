using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Shopper.DataAccess.ORM.Concrete;
using Shopper.DataServices.Interfaces;
using Shopper.Domain;

namespace Shopper.DataServices.Concrete
{
    public class InventoryService : IInventoryService
    {
        private readonly UnitOfWork _unitOfWork;

        public InventoryService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Inventory entity)
        {
            _unitOfWork.InventoryRepository.Add(entity);
        }

        public IEnumerable<Inventory> GetAll(Expression<Func<Inventory, bool>> predicate = null)
        {
            return _unitOfWork.InventoryRepository.GetAll(predicate);
        }

        public Inventory GetById(int Id)
        {
            return _unitOfWork.InventoryRepository.GetById(Id);
        }

        public void Update(Inventory entity)
        {
            _unitOfWork.InventoryRepository.Update(entity);
        }

        public void Delete(Inventory entity)
        {
            _unitOfWork.InventoryRepository.Delete(entity);
        }

        public long Count()
        {
            return _unitOfWork.InventoryRepository.Count();
        }

        public void AddRange(IEnumerable<Inventory> entities)
        {
            _unitOfWork.InventoryRepository.AddRange(entities);
        }

        public void RemoveRange(IEnumerable<Inventory> entities)
        {
            _unitOfWork.InventoryRepository.RemoveRange(entities);
        }

        public void SaveChanges()
        {
            _unitOfWork.Complete();
        }
    }
}