using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Monitor.Entities
{
    public class Booking
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Client Client { get; set; }
        public ICollection<HotelRoom> Rooms { get; set; }

    }
}
