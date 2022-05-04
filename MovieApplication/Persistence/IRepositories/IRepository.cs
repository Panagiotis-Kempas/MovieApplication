﻿using System.Linq.Expressions;

namespace MovieApplication.Persistence.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Create(TEntity entity);
        void Modified(TEntity entity);
        void Delete(TEntity entity);
    }
}