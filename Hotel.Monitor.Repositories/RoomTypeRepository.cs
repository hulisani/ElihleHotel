using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Monitor.Repository;
using Hotel.Monitor.Entities;
using Hotel.Monitor.DAL.EF;

namespace Hotel.Monitor.Repositories
{
    public class RoomTypeRepository:Repository<RoomType>
    {
        public RoomTypeRepository(HotelMonitorContext context)
            : base(context)
        {

        }
    }
}
