using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccommodationBooker.Models
{
     class Reservation : INotifyPropertyChanged
    {
        public Reservation()
        {
            this.CheckinDate = DateTime.Now.Date;
            this.CheckOutDate = CheckinDate.AddDays(1);
        }

        private Customer client;
        public Customer Client
        {
            get
            {
                return client;
            }
            set
            {
                if (client != value)
                {
                    client = value;
                    RaisePropertyChanged("Client");
                }
            }
        }

        private int numberOfPersons;
        public int NumberOfPersons
        {
            get
            {
                return numberOfPersons;
            }
            set
            {
                if (numberOfPersons != value)
                {
                    numberOfPersons = value;
                    CalculateTotalAmount();
                    RaisePropertyChanged("NumberOfPersons");
                    RaisePropertyChanged("TotalCost");
                }
            }

        }

        private List<Room> roomsReserved = new List<Room>();
        public List<Room> RoomsReserved
        {
            get
            {
                return roomsReserved;
            }
            set
            {
                if (roomsReserved != value)
                {
                    roomsReserved = value;
                    RaisePropertyChanged("RoomsReserved");
                }
            }

        }

        private decimal totalCost;
        public decimal TotalCost
        {
            get
            {
                return totalCost;             
            }
            set
            {
                if (totalCost != value)
                {
                    totalCost = value;
                    RaisePropertyChanged("TotalCost");
                }
            }
        }

        private DateTime checkinDate;
        public DateTime CheckinDate
        {
            get
            {
                return checkinDate;
            }
            set
            {
                if (checkinDate != value)
                {
                    checkinDate = value;
                    NumberOfNights = (CheckOutDate - value).Days;

                    RaisePropertyChanged("CheckinDate");
                }
            }
        }

        private DateTime checkOutDate;
        public DateTime CheckOutDate
        {
            get
            {
                return checkOutDate;
            }
            set
            {
                if (checkOutDate != value)
                {
                    NumberOfNights = (value - CheckinDate).Days;
                    checkOutDate = value;
                    RaisePropertyChanged("CheckOutDate");
                }
            }
        }

        private int numberOfNights;
        public int NumberOfNights
        {
            get
            {
                return numberOfNights;
            }
            set
            {
                if (numberOfNights != value)
                {
                    numberOfNights = value;
                    CalculateTotalAmount();
                    RaisePropertyChanged("NumberOfNights");
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

        public void CalculateTotalAmount()
        {
            decimal total = 0;
            foreach (var item in this.RoomsReserved)
            {
                item.CalculateTotalCost();
                total += item.TotalForRoom;
            }

            this.TotalCost = (total * NumberOfNights) * this.NumberOfPersons;
        }
    }
}
