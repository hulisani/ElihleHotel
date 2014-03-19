using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Monitor.Entities
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string PostalCode{get;set;}
        public string HotelSlogan { get; set; }
        public string HotelDescription { get; set; }
        public virtual ICollection<HotelRoom> Rooms { get; set; }
        public virtual ICollection<object> Images{get;set;}

    }
}
