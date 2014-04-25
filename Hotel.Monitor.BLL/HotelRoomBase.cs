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


        public ICollection<HotelRoom> GetAvailableRooms(DateTime fromDate,DateTime toDate)
        {
            BookingBase bookingBase = new BookingBase();
            var bookings = bookingBase.GetBookingByDates(fromDate, toDate);
            List<HotelRoom> bookedRooms = bookings.SelectMany(b => b.Rooms).ToList();

            List<HotelRoom> toReturn = new List<HotelRoom>();
            foreach (HotelRoom ro in roomRep.All())
            {
                if (!bookedRooms.Contains(ro))
                    toReturn.Add(ro);
            }

            return toReturn;
           // return roomRep.All().Where(r=>!bookedRooms.Contains(r)).ToList();
        }


        
    }
}
