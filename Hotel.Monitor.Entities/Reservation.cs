using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Monitor.Entities
{
    public class Reservation : Notifier
    {
        [Key]
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Customer Client { get; set; }
        public bool Parking { get; set; }
        public virtual ICollection<HotelRoom> Rooms { get; set; }
        public virtual Employee BookingEmployee { get; set; }

    }
}
