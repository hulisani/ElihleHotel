using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Monitor.Repository
{
    public interface IUnitOfWork
    {
        IRepository<TSet> GetRepository<TSet>() where TSet : class;
    }
}
