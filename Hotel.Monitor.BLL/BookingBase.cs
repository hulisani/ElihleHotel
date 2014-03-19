using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Monitor.Entities;
using Hotel.Monitor.Repositories;

namespace Hotel.Monitor.BLL
{
    public class BookingBase
    {
        Repository.IRepository<Booking> bookingRep;
        public BookingBase()
        {
            bookingRep = RepositoryUnitOfWork.Instance.GetRepository<Booking>();
        }

        public void CreateBooking(Booking booking)
        { 
            bookingRep.Create(booking);
        }

        public ICollection<Booking> GetBookingByDates(DateTime fromDate, DateTime toDate)
        {
           var booking = bookingRep.All().Where(b => b.FromDate >= fromDate && b.ToDate <= toDate);
           return booking.ToList();
        }
    }
}
