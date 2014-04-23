
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Monitor.BLL;

namespace AccommodationBooker.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {

            HotelRoomBase hrb = new HotelRoomBase();
            FullReservationList = hrb.GetRooms();
            //FullReservationList = new List<Room>()
            //{
            //    new Room { ReservationId = 1, viewModel = this, Breakfast = false, Description = "Beautifull double bedroom overlooking the ocean sunset", Parking = false, Price = 500, Reserved = false, Type = "Double", CanReserve = true},
            //    new Room { ReservationId = 2, viewModel = this, Breakfast = false, Description = "Deluxe room overlooking the ocean sunset. Sleeps maximum of 2 people. Has shower, fridge and DSTV", Parking = false, Price = 250, Reserved = false, Type = "Single", CanReserve = true},
            //    new Room { ReservationId = 3, viewModel = this, Breakfast = false, Description = "Beautifull double bedroom overlooking the ocean sunset", Parking = false, Price = 500, Reserved = false, Type = "Double", CanReserve = true},
            //    new Room { ReservationId = 4, viewModel = this, Breakfast = false, Description = "Beautifull family bedroom overlooking the ocean sunset", Parking = false, Price = 750, Reserved = false, Type = "Family", CanReserve = true},
            //    new Room { ReservationId = 5, viewModel = this, Breakfast = false, Description = "Beautifull single bedroom overlooking the ocean sunset", Parking = false, Price = 200, Reserved = false, Type = "Single", CanReserve = true}
            //};

            NumRoomsAvailable = FullReservationList.Count;

            RoomReservations = FullReservationList;
            this.NewCustomer = new Hotel.Monitor.Entities.Customer();

            NumberOfPersonsList = new List<int>()
            {
                1,2,3,4,5,6
            };

            TitlesList = new List<string>()
            {
                "Mr", "Mrs", "Miss", "Dr"
            };

            RoomTypeBase rtb = new RoomTypeBase();
            ReservationTypes = rtb.GetTypes();
            //ReservationTypes = new List<string>()
            //{
            //    "All", "Single", "Double", "Family", "Deluxe"
            //};

            this.NewReservation = new Hotel.Monitor.Entities.Reservation();
        }

        private int numRoomsAvailable;
        public int NumRoomsAvailable
        {
            get
            {
                return numRoomsAvailable;
            }
            set
            {
                if (numRoomsAvailable != value)
                {
                    numRoomsAvailable = value;
                    RaisePropertyChanged("NumRoomsAvailable");
                }
            }
        }

        private List<int> numberOfPersonsList;
        public List<int> NumberOfPersonsList
        {
            get
            {
                return numberOfPersonsList;
            }
            set
            {
                if (numberOfPersonsList != value)
                {
                    numberOfPersonsList = value;
                    RaisePropertyChanged("NumberOfPersonsList");
                }
            }
        }

        private Hotel.Monitor.Entities.Reservation newReservation;
        public Hotel.Monitor.Entities.Reservation NewReservation
        {
            get
            {
                return newReservation;
            }
            set
            {
                if (newReservation != value)
                {
                    newReservation = value;
                    RaisePropertyChanged("NewReservation");                   
                }
            }
        }

        private ICollection<Hotel.Monitor.Entities.HotelRoom> roomReservations;
        public ICollection<Hotel.Monitor.Entities.HotelRoom> RoomReservations
        {
            get
            {
                return roomReservations;
            }
            set
            {
                if (roomReservations != value)
                {
                    roomReservations = value;
                    RaisePropertyChanged("RoomReservations");
                    RaisePropertyChanged("SelectedRoom");
                }
            }
        }

        private ICollection<Hotel.Monitor.Entities.HotelRoom> fullReservationList;
        public ICollection<Hotel.Monitor.Entities.HotelRoom> FullReservationList
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

        private decimal reservationAmount;
        public decimal ReservationAmount
        {
            get
            {
                return reservationAmount;
            }
            set
            {
                if (reservationAmount != value)
                {
                    reservationAmount = value;
                    RaisePropertyChanged("ReservationAmount");
                }
            }

        }

        private bool reservationEnabled;
        public bool ReservationEnabled
        {
            get
            {
                return reservationEnabled;
            }
            set
            {
                if (reservationEnabled != value)
                {
                    reservationEnabled = value;
                    RaisePropertyChanged("ReservationEnabled");
                }
            }
        }

        private Hotel.Monitor.Entities.Customer newCustomer;
        public Hotel.Monitor.Entities.Customer NewCustomer
        {
            get
            {
                return newCustomer;
            }
            set
            {
                if (newCustomer != value)
                {
                    newCustomer = value;
                    RaisePropertyChanged("NewCustomer");
                }
            }

        }

        private List<string> titlesList;
        public List<string> TitlesList
        {
            get
            {
                return titlesList;
            }
            set
            {
                if (titlesList != value)
                {
                    titlesList = value;
                    RaisePropertyChanged("TitlesList");

                }
            }
        }

        private ICollection<string> reservationTypes;
        public ICollection<string> ReservationTypes
        {
            get
            {
                return reservationTypes;
            }
            set
            {
                if (reservationTypes != value)
                {
                    reservationTypes = value;
                    RaisePropertyChanged("ReservationTypes");

                }
            }
        }

        private string selectedReservationType;
        public string SelectedReservationType
        {
            get
            {
                return selectedReservationType;
            }
            set
            {
                if (selectedReservationType != value)
                {
                    selectedReservationType = value;
                    RaisePropertyChanged("SelectedReservationType");
                    FilterRoomsByType(value);
                }
            }
        }

        private void FilterRoomsByType(string value)
        {
            if (value != "All")
            {
                RoomReservations = this.FullReservationList.Where(x => x.RoomType != null && x.RoomType.HotelRoomType == value).ToList();
            }
            else
                RoomReservations = this.FullReservationList;           
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

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            // take a copy to prevent thread issues
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        internal void GetReservedRoom()
        {
            
            //NewReservation.RoomsReserved = null;
            //NewReservation.RoomsReserved = RoomReservations.Where(x => x.ActiveBooking != null).ToList();

            //if (NewReservation.RoomsReserved != null)
            //{
            //    NewReservation.CalculateTotalAmount();
            //}
                     
        }
    }
}
