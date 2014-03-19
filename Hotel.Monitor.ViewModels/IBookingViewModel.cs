using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Monitor.Entities;

namespace Hotel.Monitor.ViewModels
{
    public interface IBookingViewModel
    {
         DateTime FromDate { get; set; }
         DateTime ToDate { get; set; }
         Client Client { get; set; }
         ICollection<HotelRoom> Rooms { get; set; }

    }
}
