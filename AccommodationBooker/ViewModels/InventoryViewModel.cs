
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccommodationBooker.ViewModels
{
    public class InventoryViewModel : INotifyPropertyChanged
    {
        public InventoryViewModel()
        {
            FullReservationList = new List<Hotel.Monitor.Entities.HotelRoom>()
            {
                new Hotel.Monitor.Entities.HotelRoom { Id = 1,  Description = "Beautifull double bedroom overlooking the ocean sunset", RoomType = new Hotel.Monitor.Entities.RoomType{Id =1,HotelRoomType = "Double"}},
                new Hotel.Monitor.Entities.HotelRoom { Id = 1,  Description = "Deluxe room overlooking the ocean sunset. Sleeps maximum of 2 people. Has shower, fridge and DSTV", RoomType = new Hotel.Monitor.Entities.RoomType{Id =1,HotelRoomType = "Double"}}
               // new Room { ReservationId = 2,  Breakfast = false, Description = "Deluxe room overlooking the ocean sunset. Sleeps maximum of 2 people. Has shower, fridge and DSTV", Parking = false, Price = 250, Reserved = false, Type = "Single", CanReserve = true},
               // new Room { ReservationId = 3,  Breakfast = false, Description = "Beautifull double bedroom overlooking the ocean sunset", Parking = false, Price = 500, Reserved = false, Type = "Double", CanReserve = true},
               // new Room { ReservationId = 4,  Breakfast = false, Description = "Beautifull family bedroom overlooking the ocean sunset", Parking = false, Price = 750, Reserved = false, Type = "Family", CanReserve = true}
            };
        }

        private List<Hotel.Monitor.Entities.HotelRoom> fullReservationList;
        public List<Hotel.Monitor.Entities.HotelRoom> FullReservationList
        {
            get
            {
                return fullReservationList;
            }
            set
            {
                if (fullReservationList != value)
                {
                    fullReservationList = value;
                    RaisePropertyChanged("FullReservationList");
                }
            }
        }

        private Hotel.Monitor.Entities.HotelRoom selectedRoom;
        public Hotel.Monitor.Entities.HotelRoom SelectedRoom
        {
            get
            {
                return selectedRoom;
            }

            set
            {
                if (selectedRoom != value)
                {
                    selectedRoom = value;
                    RaisePropertyChanged("SelectedRoom");
                }
            }

        }

        private void RaisePropertyChanged(string propertyName)
        {
            // take a copy to prevent thread issues
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
