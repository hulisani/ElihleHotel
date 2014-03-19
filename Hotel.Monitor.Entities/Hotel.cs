using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Monitor.Entities
{
    public class Hotel
    {
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string PostalCode{get;set;}
        public string HotelSlogan { get; set; }
        public string HotelDescription { get; set; }
        public ICollection<HotelRoom> Rooms { get; set; }
        public ICollection<object> Images{get;set;}

    }
}
