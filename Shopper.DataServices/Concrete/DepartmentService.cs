using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Shopper.DataAccess.DataTier.Repo.Concrete;
using Shopper.DataAccess.DataTier.Repo.Interfaces;
using Shopper.DataServices.Interfaces;
using Shopper.Domain;

namespace Shopper.DataServices.Concrete
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DepartmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Department entity)
        {
            _unitOfWork.DepartmentRepository.Add(entity);
        }

        public IEnumerable<Department> GetAll(Expression<Func<Department, bool>> predicate = null)
        {
            return _unitOfWork.DepartmentRepository.GetAll(predicate);
        }

        public Department GetById(int Id)
        {
            return _unitOfWork.DepartmentRepository.GetById(Id);
        }

        public void Update(Department entity)
        {
            _unitOfWork.DepartmentRepository.Update(entity);
        }

        public void Delete(Department entity)
        {
            _unitOfWork.DepartmentRepository.Delete(entity);
        }

        public long Count()
        {
            return _unitOfWork.DepartmentRepository.Count();
        }

        public void AddRange(IEnumerable<Department> entities)
        {
            _unitOfWork.DepartmentRepository.AddRange(entities);
        }

        public void RemoveRange(IEnumerable<Department> entities)
        {
            _unitOfWork.DepartmentRepository.RemoveRange(entities);
        }

        public void SaveChanges()
        {
            _unitOfWork.Complete();
        }
    }
}