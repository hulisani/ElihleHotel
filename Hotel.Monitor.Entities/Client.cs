using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Monitor.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CellNumber { get; set; }
        public Booking Booking { get; set; }
    }
}
