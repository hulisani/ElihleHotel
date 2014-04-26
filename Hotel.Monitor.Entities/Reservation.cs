using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Monitor.Entities
{
    public class Reservation : Notifier,IEquatable<Reservation>
    {

        private int id;
        [Key]
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

        private Customer client;
        public Customer Client 
        {
            get
            {
                return client;
            }
            set
            {
                client = value;
                RaisePropertyChanged("Client");
            }
        }

        private bool breakfast;
        public bool Breakfast
        {
            get
            {
                return breakfast;
            }
            set
            {
                breakfast = value;
                RaisePropertyChanged("Breakfast");
            }
        }

        private bool checkedIn;

        public bool CheckedIn
        {
            get
            {
                return checkedIn;
            }
            set
            {
                checkedIn = value;
                RaisePropertyChanged("CheckedIn");
            }
        }

        private bool parking;
        public bool Parking 
        {
            get
            {
                return parking;
            }
            set
            {
                parking = value;
                RaisePropertyChanged("Parking");
            }
        }

        private ICollection<HotelRoom> rooms;
         
        public virtual  ICollection<HotelRoom> Rooms
        {
            get
            {
                return rooms;
            }
            set
            {
                rooms = value;
                RaisePropertyChanged("Rooms");
            }
        }

        [NotMapped]
        public string RoomsSummary
        {
            get
            {
                string roomStr = string.Empty;
                if (Rooms != null)
                {
                    foreach (var room in Rooms)
                    {
                        roomStr += room.Name + "  " ;
                    }
                }

                return roomStr;
            }
        }

        private Employee bookingEmployee;

        public virtual Employee BookingEmployee
        {
            get
            {
                return bookingEmployee;
            }
            set
            {
                bookingEmployee = value;
                RaisePropertyChanged("BookingEmployee");
            }
        }



        public int numPeople;

        public int NumberOfPersons
        {
            get
            {
                return numPeople;
            }
            set
            {
                numPeople = value;
                RaisePropertyChanged("NumberOfPersons");
            }
        }

        [NotMapped]
        public int NumberOfNights
        {
            get
            {
                var dt = ToDate - FromDate;
                return dt.Days;
            }
        }


        private decimal totalCost;
        [NotMapped]
        public decimal TotalCost
        {
            get
            {
                decimal total = 0;
                if (Rooms != null)
                {
                    foreach (HotelRoom room in Rooms)
                        total += room.Price;

                }
                totalCost = total * NumberOfPersons;
                return totalCost;
            }
            set
            {
                totalCost = value;
                RaisePropertyChanged("TotalCost");
            }
         
        }

        private ICollection<ReservationPayment> reservationPayments;

        public virtual ICollection<ReservationPayment> ReservationPayments
        {
            get
            {
                return reservationPayments;
            }
            set
            {
                reservationPayments = value;
                RaisePropertyChanged("ReservationPayments");
            }
        }

        public void CalculateTotalAmount()
        {
            decimal total = 0;
            foreach (var item in this.Rooms)
            {
                total += item.Price;
            }

            this.TotalCost = (total * NumberOfNights);
        }

        public bool Equals(Reservation other)
        {
            return this.Id == other.Id;
        }
    }
}
