using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Monitor.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CellNumber { get; set; }
        public virtual ICollection<Booking> Bookings {get;set;}
    }
}
