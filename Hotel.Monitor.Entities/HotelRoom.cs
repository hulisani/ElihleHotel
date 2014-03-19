using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Monitor.Entities
{
    public class HotelRoom
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Booking ActiveBooking { get; set; }
        public bool IsBooked
        {
            get
            {
                return ActiveBooking == null;
            }
        }
    }
}
