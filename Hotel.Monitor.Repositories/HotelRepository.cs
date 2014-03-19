using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Monitor.Repository;
using Hotel.Monitor.DAL.EF;

namespace Hotel.Monitor.Repositories
{
    public class HotelRepository : Repository<Hotel.Monitor.Entities.Hotel>
    {
        public HotelRepository(HotelMonitorContext context) :base(context)
        {
          
        }
    }
}
