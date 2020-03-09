using Framkalla.Contracts.Repositories;
using Framkalla.Entities;
using Framkalla.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Framkalla.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : Base
    {
        public RepositoryBase(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }
        protected RepositoryContext RepositoryContext { get; set; }

        public virtual void Add(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
        }

        public virtual IQueryable<T> GetAll()
        {
            return this.RepositoryContext.Set<T>().AsNoTracking();
        }

        public virtual IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes)
        {
            var result = this.RepositoryContext.Set<T>().AsNoTracking();

            if (includes != null)
            {
                result = includes.Aggregate(result,
                          (current, include) => current.Include(include));
            }

            return result.Where(expression);
        }

        public virtual void Remove(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
        }

        public virtual void Update(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
        }
    }
}
