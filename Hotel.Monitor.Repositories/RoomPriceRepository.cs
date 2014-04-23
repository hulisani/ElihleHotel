using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Monitor.Entities;
using Hotel.Monitor.Repository;
using Hotel.Monitor.DAL.EF;

namespace Hotel.Monitor.Repositories
{
    public class RoomPriceRepository : Repository<RoomPrice>
    {
        public RoomPriceRepository(HotelMonitorContext context)
            : base(context)
        {

        }
    }
}
