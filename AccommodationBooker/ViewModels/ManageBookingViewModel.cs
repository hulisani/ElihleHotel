﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Monitor.BLL;
using Hotel.Monitor.Entities;

namespace AccommodationBooker.ViewModels
{
    public class ManageBookingViewModel : INotifyPropertyChanged
    {
        public ManageBookingViewModel()
        {
            FromDate = DateTime.Today;
            ToDate = DateTime.Today.AddDays(365);
            BookingBase bb = new BookingBase();
            FullReservationList = bb.GetAllBookings();

        }




        private DateTime fromDate;

        public DateTime FromDate
        {
            get
            {
                return fromDate;
            }
            set
            {
                fromDate = value;
                RaisePropertyChanged("FromDate");
            }
        }


        private DateTime toDate;

        public DateTime ToDate
        {
            get
            {
                return toDate;
            }
            set
            {
                toDate = value;
                RaisePropertyChanged("ToDate");
            }
        }


        private string searchCustomer;
        public string SearchCustomerName
        {
            get
            {
                return searchCustomer;
            }
            set
            {
                searchCustomer = value;
                RaisePropertyChanged("SearchCustomerName");
            }
        }

        private Reservation reservation;

        public Reservation SelectedReservation
        {
            get
            {
                return reservation;
            }
            set
            {
                reservation = value;
                RaisePropertyChanged("SelectedReservation");
            }
        }

        private ICollection<Hotel.Monitor.Entities.Reservation> fullReservationList;
        public ICollection<Hotel.Monitor.Entities.Reservation> FullReservationList
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
