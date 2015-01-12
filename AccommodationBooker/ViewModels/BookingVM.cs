using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Monitor.Entities;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using AccommodationBooker.Commands;
using Hotel.Monitor.BLL;

namespace AccommodationBooker.ViewModels
{
    public class BookingVM : INotifyPropertyChanged
    {
        private Reservation reservation;
        public BookingVM(Reservation reservation)
        {
            this.reservation = reservation;
        }


        public string ClientName
        {
            get
            {
                if (reservation.Client == null)
                    return string.Empty;
                return string.Format("{0} {1}", reservation.Client.FirstName , reservation.Client.Surname);
            }
        }

        public int NumberOfPersons
        {
            get
            {
                return reservation.NumberOfPersons;
            }
            set
            {
                reservation.NumberOfPersons = value;
                RaisePropertyChanged("NumberOfPersons");
            }
        }


        public bool Parking
        {
            get
            {
                return reservation.Parking;
            }
            set
            {
                reservation.Parking = value;
                RaisePropertyChanged("Parking");
            }
        }


        public bool CheckedIn
        {
            get
            {
                return reservation.CheckedIn;
            }
            set
            {
                reservation.CheckedIn = value;
                RaisePropertyChanged("CheckedIn");
            }
        }


        public bool CheckedOut
        {
            get
            {
                return reservation.CheckedOut;
            }
            set
            {
                reservation.CheckedOut = value;
                RaisePropertyChanged("CheckedOut");
            }
        }

        private ObservableCollection<ReservationPayment> payments;
        public ObservableCollection<ReservationPayment> Payments
        {
            get
            {
                if (reservation.ReservationPayments == null)
                    payments = new ObservableCollection<ReservationPayment>(reservation.ReservationPayments);
                else
                    payments = new ObservableCollection<ReservationPayment>( reservation.ReservationPayments);

                return payments;
            }
            set
            {
                payments = value;
                RaisePropertyChanged("Payments");
            }
        }


        public ObservableCollection<HotelRoom> Rooms
        {
            get
            {
                if (reservation.Rooms != null)
                    return new ObservableCollection<HotelRoom>(reservation.Rooms);
                else
                    return new ObservableCollection<HotelRoom>();
            }
  
        }
        public int NumberOfNights
        {
            get
            {
                return reservation.NumberOfNights;
            }
        }


        public decimal TotalCost
        {
            get
            {
                return reservation.TotalCost;
            }
        }

        public decimal OutstandingAmount
        {
            get
            {
                return reservation.OutstandingAmount;
            }
        }
        public DateTime FromDate
        {
            get
            {
                return reservation.FromDate;
            }
            set
            {
                reservation.FromDate = value;
                RaisePropertyChanged("FromDate");
            }
        }

        public DateTime ToDate
        {
            get
            {
                return reservation.ToDate;
            }
            set
            {
                reservation.ToDate = value;
                RaisePropertyChanged("ToDate");
            }
        }

        private decimal amoountBeingPaid;
        public decimal AmountBeingPaid
        {
            set
            {
                amoountBeingPaid = value;
                RaisePropertyChanged("AmountBeingPaid");
            }
            get
            {
                return amoountBeingPaid;
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



        public ICommand saveCommand
        {
            get { return new DelegateCommand(UpdateReservation); }

        }

        public ICommand addPayment
        {
            get { return new DelegateCommand(AddPayment); }
        }
        public void AddPayment()
        {
            if (AmountBeingPaid != 0)
            {
                ReservationPayment payment = new ReservationPayment { PaymentDate = DateTime.Now, PaymentAmount = AmountBeingPaid, Reservation = reservation };
                if (reservation.ReservationPayments == null) reservation.ReservationPayments = new List<ReservationPayment>();
                reservation.ReservationPayments.Add(payment);
                Payments = new ObservableCollection<ReservationPayment>( reservation.ReservationPayments);
            }
        }

        public void UpdateReservation()
        {
            BookingBase bookingBase = new BookingBase();
            bookingBase.UpdateBooking(reservation);
        }
    }
}
