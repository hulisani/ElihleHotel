using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Monitor.DAL.EF;
using System.Data.Entity;

namespace Hotel.Monitor.Repository
{
    public class Repository<T> : IRepository<T> where T:class
    {

        protected DbContext context;
        public Repository(DbContext context)
        {
            this.context = context;
        }

        protected DbSet<T> DbSet
        {
            get
            {
                return context.Set<T>();
            }
        }

        public IQueryable<T> All()
        {
            return DbSet.AsQueryable();
        }

        public IQueryable<T> Filter(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate).AsQueryable<T>();
        }

        public bool Delete(T t)
        {
            throw new NotImplementedException();
        }

        public bool Update(T t)
        {
            throw new NotImplementedException();
        }

        public T Create(T t)
        {
            var newEntry = DbSet.Add(t);
            context.SaveChanges();
            return newEntry;
        }
    }
}
