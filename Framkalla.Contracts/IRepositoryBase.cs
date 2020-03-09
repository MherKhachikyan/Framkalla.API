using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Framkalla.Contracts.Repositories
{
    public interface IRepositoryBase<T>
    {
        void Update(T entity);
        void Add(T entity); 
        void Remove(T entity);
        IQueryable<T> GetAll();
        IQueryable<T> FindByCondition(Expression<Func<T,bool>> expression, params Expression<Func<T, object>>[] includes);
    }
}
