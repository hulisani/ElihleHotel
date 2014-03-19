using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Monitor.Entities
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Client Client { get; set; }
        public virtual ICollection<HotelRoom> Rooms { get; set; }
        public virtual Employee BookingEmployee { get; set; }
    }
}
