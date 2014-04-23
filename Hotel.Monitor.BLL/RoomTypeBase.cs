using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Monitor.Entities;
using Hotel.Monitor.Repository;
using Hotel.Monitor.Repositories;

namespace Hotel.Monitor.BLL
{
    public class RoomTypeBase
    {
         IRepository<RoomType> roomTypeRep;
         public RoomTypeBase()
         {
             roomTypeRep = RepositoryUnitOfWork.Instance.GetRepository<RoomType>();
         }


         public RoomType CreateRoomType(RoomType rt)
         {
            return roomTypeRep.Create(rt);
         }

         public RoomType GetRoomType(string roomType)
         {
            return  roomTypeRep.All().FirstOrDefault(r => r.HotelRoomType == roomType);
         }

         public ICollection<string> GetTypes()
         {
           return roomTypeRep.All().Select(t => t.HotelRoomType).ToList();
         }

    }
}
