using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Shopper.DataAccess.DataTier.Repo.Concrete;
using Shopper.DataAccess.DataTier.Repo.Interfaces;
using Shopper.DataServices.Interfaces;
using Shopper.Domain;

namespace Shopper.DataServices.Concrete
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Customer entity)
        {
            _unitOfWork.CustomerRepository.Add(entity);
        }

        public IEnumerable<Customer> GetAll(Expression<Func<Customer, bool>> predicate = null)
        {
            return _unitOfWork.CustomerRepository.GetAll(predicate);
        }

        public Customer GetById(int Id)
        {
            return _unitOfWork.CustomerRepository.GetById(Id);
        }

        public void Update(Customer entity)
        {
            _unitOfWork.CustomerRepository.Update(entity);
        }

        public void Delete(Customer entity)
        {
            _unitOfWork.CustomerRepository.Delete(entity);
        }

        public long Count()
        {
            return _unitOfWork.CustomerRepository.Count();
        }

        public void AddRange(IEnumerable<Customer> entities)
        {
            _unitOfWork.CustomerRepository.AddRange(entities);
        }

        public void RemoveRange(IEnumerable<Customer> entities)
        {
            _unitOfWork.CustomerRepository.RemoveRange(entities);
        }

        public void SaveChanges()
        {
            _unitOfWork.Complete();
        }
    }
}