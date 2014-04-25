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
        Repository.IRepository<Reservation> bookingRep;
        public BookingBase()
        {
            bookingRep = RepositoryUnitOfWork.Instance.GetRepository<Reservation>();
        }

        public void CreateBooking(Reservation booking)
        { 
            bookingRep.Create(booking);
        }

        public ICollection<Reservation> GetBookingByDates(DateTime fromDate, DateTime toDate)
        {
           var booking = bookingRep.All().Where(
                                                b => (b.FromDate >= fromDate && b.FromDate <= toDate) ||
                                                ( b.ToDate >=fromDate && b.ToDate <= toDate)
                                                 );
           return booking.ToList();
        }

        public ICollection<Reservation> GetAllBookings()
        {
            return bookingRep.All().ToList();
        }

        

       // public ICollection<Reservation> GetBooking 
    }
}
