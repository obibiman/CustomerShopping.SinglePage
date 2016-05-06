﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Shopper.DataAccess.DataTier.Repo.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Get(Expression<Func<T, bool>> predicate);
        T GetById(int Id);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        long Count();
        //
        void AddRange(IEnumerable<T> entities);
        void RemoveRange(IEnumerable<T> entities);
    }
}