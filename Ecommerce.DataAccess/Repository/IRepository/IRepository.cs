using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Ecommerce.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T Get(Expression<Func<T, bool>> expression);

        void Remove(T entity);

        void Add(T entity);

        void RemoveRange(IEnumerable<T> entities);
    }
}
