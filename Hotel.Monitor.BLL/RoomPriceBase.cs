using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Monitor.Entities;
using Hotel.Monitor.Repository;
using Hotel.Monitor.Repositories;

namespace Hotel.Monitor.BLL
{
    public class RoomPriceBase
    {
         IRepository<RoomPrice> roomPriceRep;
         public RoomPriceBase()
         {
            roomPriceRep = RepositoryUnitOfWork.Instance.GetRepository<RoomPrice>();
         }


         public void CreateRoomPrice(RoomPrice price)
         {
             roomPriceRep.Create(price);
         }

         public ICollection<RoomPrice> GetPriceByType(string roomType)
         {
             return roomPriceRep.All().Where(r => r.RoomType.HotelRoomType == roomType).ToList();
         }

         public ICollection<RoomPrice> GetPriceByType(RoomType roomType)
         {
             return GetPriceByType(roomType.HotelRoomType);
         }
    }
}
