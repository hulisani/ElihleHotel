using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Monitor.BLL;
using Hotel.Monitor.Entities;

namespace HotelMonitor.Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            HotelBase ho = new HotelBase();
            Console.WriteLine("Creating Hotel...");
            Hotel.Monitor.Entities.Hotel h = new Hotel.Monitor.Entities.Hotel();
            h.Name = "Huli Test Hotel";
            h.HotelDescription = "Hotel in the bundus";
            ho.CreateHotel(h);
            Console.WriteLine("Finished Creating Hotel");
            Console.ReadLine();
        }
    }
 }
