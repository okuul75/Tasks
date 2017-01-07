﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Task.Domain.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        T Get(Expression<Func<T, bool>> where);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
    }
}
