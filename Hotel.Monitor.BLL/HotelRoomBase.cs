using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Monitor.Entities;
using Hotel.Monitor.Repository;
using Hotel.Monitor.Repositories;

namespace Hotel.Monitor.BLL
{
    public class HotelRoomBase
    {
        IRepository<HotelRoom> roomRep;
        public HotelRoomBase()
        {
            roomRep = RepositoryUnitOfWork.Instance.GetRepository<HotelRoom>();
        }

        public ICollection<HotelRoom> GetRooms()
        {
            return roomRep.All().ToList();
        }

        public void CreateRoom(HotelRoom room)
        {
            roomRep.Create(room);
        }


        public ICollection<HotelRoom> GetAvailableRooms()
        {
            return roomRep.All().Where(r => r.ActiveBooking == null).ToList();
        }


     
    }
}
