using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Hotel.Monitor.Repository
{
    public interface IRepository<T> where T:class
    {
        IQueryable<T> All();

        IQueryable<T> Filter(Expression<Func<T, bool>> predicate);

        bool Delete(T t);

        bool Update(T t);

        T Create(T t);

    }
}
