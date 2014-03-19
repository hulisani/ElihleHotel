using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Monitor.Entities
{
    public class HotelRoom
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Booking ActiveBooking { get; set; }
        public bool IsBooked
        {
            get
            {
                return ActiveBooking == null;
            }
        }
    }
}
