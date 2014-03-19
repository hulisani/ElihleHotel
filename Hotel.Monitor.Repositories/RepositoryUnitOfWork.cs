using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Monitor.Repository;
using System.Data.Entity.Core.Objects;
using Hotel.Monitor.DAL.EF;

namespace Hotel.Monitor.Repositories
{
    public class RepositoryUnitOfWork : IUnitOfWork 
    {
        private HotelMonitorContext context;
        private Dictionary<Type, object> repositories;
       

        private RepositoryUnitOfWork()
        {
           repositories = new Dictionary<Type, object>();
           context = new HotelMonitorContext();
        }

        private static RepositoryUnitOfWork instance;
        public static RepositoryUnitOfWork Instance
        {
            get
            {
                if (instance == null)
                    instance = new RepositoryUnitOfWork();
                return instance;
            }
        }
        public IRepository<TSet> GetRepository<TSet>() where TSet : class
        {
            if (repositories.Keys.Contains(typeof(TSet)))
                return repositories[typeof(TSet)] as IRepository<TSet>;

            var repository = new Repository<TSet>(context);
            repositories.Add(typeof(TSet), repository);
            return repository;
        }


    }
}
