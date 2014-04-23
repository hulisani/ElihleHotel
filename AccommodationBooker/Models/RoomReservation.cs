using AccommodationBooker.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccommodationBooker.Models
{
     class Room : INotifyPropertyChanged
    {

        public MainWindowViewModel viewModel = null;
        private Decimal breakfastAmount = 80;
        
        private int reservationId;
        public int ReservationId
        {
            get { return reservationId; }
            set
            {
                if (reservationId != value)
                {
                    reservationId = value;
                    RaisePropertyChanged("ReservationId");
                }
            }
        }

        private string type;
        public string Type 
        {
            get { return type; }
            set
            {
                if (type != value)
                {
                    type = value;
                    RaisePropertyChanged("Type");
                }
            } 
        }

        private decimal price; 
        public decimal Price 
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    RaisePropertyChanged("Price");
                }
            } 
        }

        private string description;
        public string Description 
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    RaisePropertyChanged("Description");
                }
            } 
        }

        private bool breakfast;
        public bool Breakfast 
        {
            get { return breakfast; }
            set
            {
                if (breakfast != value)
                {
                    breakfast = value;
                    RaisePropertyChanged("Breakfast");
                    CalculateTotalCost();
                    RaisePropertyChanged("TotalCost");
                    
                }
            }  
        }

        private Reservation activeBooking;
        public Reservation ActiveBooking
        {
            get { return activeBooking; }
            set
            {
                if (activeBooking != value)
                {
                    activeBooking = value;
                    RaisePropertyChanged("ActiveBooking");
                }
            }
        }

        private bool parking;
        public bool Parking 
        {
            get { return parking; }
            set
            {
                if (parking != value)
                {
                    parking = value;
                    RaisePropertyChanged("Parking");
                }
            }  
        }

        private decimal totalForRoom;
        public decimal TotalForRoom
        {
            get { return totalForRoom; }
            set
            {
                if (totalForRoom != value)
                {
                    totalForRoom = value;
                    RaisePropertyChanged("TotalForRoom");
                }
            }
        }

        public void CalculateTotalCost()
        {
            var originalAmountMinSpecial = (Price - Special);
            TotalForRoom = Price + (Breakfast ? breakfastAmount : 0);            
        }

        private bool reserved;
        public bool Reserved 
        {
            get { return reserved; }
            set
            {
                if (reserved != value)
                {
                    reserved = value;
                    RaisePropertyChanged("Reserved");
                    if(value == true)
                    {
                        this.viewModel.NewCustomer.RoomsReserved.Add(this.ReservationId);
                       // this.viewModel.NewCustomer.RefreshChangedProperties();
                    }
                    else
                    {
                        this.viewModel.NewCustomer.RoomsReserved.Remove(this.ReservationId);
                       // this.viewModel.NewCustomer.RefreshChangedProperties();
                    }
                }
            }  
        }

        private decimal special;
        public decimal Special 
        {
            get { return special; }
            set
            {
                if (special != value)
                {
                    special = value;
                    RaisePropertyChanged("Special");
                }
            }  
        }

        private bool canReserve;
        public bool CanReserve 
        {
            get { return canReserve; }
            set 
            {
                if (canReserve != value)
                {
                    canReserve = value;
                    RaisePropertyChanged("CanReserve");
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
    }
}
