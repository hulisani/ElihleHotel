using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Monitor.BLL;
using Hotel.Monitor.Entities;
using System.Threading.Tasks;

namespace HotelMonitor.Test
{
    public class Program
    {
        static void Main(string[] args)
        {

            HotelRoomBase hrb = new HotelRoomBase();
            var rooms = hrb.GetRooms();
            var availableRooms = hrb.GetAvailableRooms(DateTime.Today.AddDays(1), DateTime.Today.AddDays(51));

            Parallel.ForEach(rooms, room =>                 
                Console.WriteLine("Found Room : " + room.Name + "..." + "Available: " + availableRooms.Contains(room))                
                );

            Console.ReadLine();
            //RoomType rt = new RoomType();
           // rt.HotelRoomType = "Double Room";


            //HotelBase ho = new HotelBase();
            //Console.WriteLine("Creating Hotel...");
            //Hotel.Monitor.Entities.Hotel h = new Hotel.Monitor.Entities.Hotel();

            //Console.WriteLine("Enter the hotel Name you want to create");
            //string hName = Console.ReadLine();
            //h.Name = hName;

            //ho.CreateHotel(h);

            //Console.WriteLine("Hotel Created with Name " + h.Name);



            //h.Name = "Huli Test Hotel";
            //h.HotelDescription = "Hotel in the bundus";
            //ho.CreateHotel(h);
            Console.WriteLine("Finished Creating Hotel");
            Console.ReadLine();
        }
    }
 }
