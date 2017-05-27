using Repository.Abstracts.GenericEntity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repository.Abstracts.Repository
{
    public interface IRepository<T> where T : EntityBase
    {
        T GetByID (int Id);
        IEnumerable<T> GetAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        T AddOrUpdate(T entity);
        IEnumerable<T> AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
