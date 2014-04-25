using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Monitor.Entities
{
    public class ReservationPayment : Notifier
    {

        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                RaisePropertyChanged("Id");
            }
        }


        private Reservation reservation;

        public virtual Reservation Reservation
        {
            get
            {
                return reservation;
            }
            set
            {
                reservation = value;
                RaisePropertyChanged("Reservation");
            }
        }

        private DateTime paymentDate;

        public DateTime PaymentDate
        {
            get
            {
                return paymentDate;
            }
            set
            {
                paymentDate = value;
                RaisePropertyChanged("PaymentDate");
            }
        }


        private decimal paymentAmount;

        public decimal PaymentAmount
        {
            get
            {
                return paymentAmount;
            }
            set
            {
                paymentAmount = value;
                RaisePropertyChanged("PaymentAmount");
            }
        }
    }
}
