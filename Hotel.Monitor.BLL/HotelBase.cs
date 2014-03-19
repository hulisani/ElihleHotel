using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Monitor.Repository;
using Hotel.Monitor.Repositories;

namespace Hotel.Monitor.BLL
{
    public class HotelBase
    {
        IRepository<Hotel.Monitor.Entities.Hotel> hotelRep;

        public HotelBase()
        {
            hotelRep = RepositoryUnitOfWork.Instance.GetRepository<Hotel.Monitor.Entities.Hotel>();
        }

        public ICollection<Hotel.Monitor.Entities.Hotel> GetHotels()
        {
            return hotelRep.All().ToList();
        }

        public Hotel.Monitor.Entities.Hotel GetHotel()
        {
            return hotelRep.All().FirstOrDefault();
        }

        public void CreateHotel(Entities.Hotel hotel)
        {
            hotelRep.Create(hotel);
        }
    }
}
