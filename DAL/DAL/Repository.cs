using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using Repository.Abstracts.Repository;
using Repository.Abstracts.GenericEntity;
using Repository.DbContext;

namespace Repository
{
    public class Repository<T> : IRepository<T> where T: EntityBase
    {
        protected readonly RepContext _context;

        public Repository(RepContext context)
        {
            _context = context;
        }

        public T AddOrUpdate(T entity)
        {
            _context.Entry<T>(entity).State = (entity.Id != 0) ? EntityState.Modified : EntityState.Added;
            return entity;
        }

        public IEnumerable<T> AddRange(IEnumerable<T> entities)
        {
            return _context.Set<T>().AddRange(entities);

        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetByID(int Id)
        {
            return _context.Set<T>().Find(Id);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
    }
}
