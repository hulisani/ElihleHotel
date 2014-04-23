using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Monitor.Entities
{
    public class Customer : Notifier
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

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    RaisePropertyChanged("FirstName");
                }
            }
        }

        private string surname;
        public string Surname 
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
                RaisePropertyChanged("Surname");
            }
        }

        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                RaisePropertyChanged("Title");
            }
        }

        private string nationality;
        public string Nationality
        {
            get { return nationality; }
            set
            {
                if (nationality != value)
                {
                    nationality = value;
                    RaisePropertyChanged("Nationality");
                }
            }
        }

        private string contact;
        public string Contact
        {
            get { return contact; }
            set
            {
                if (contact != value)
                {
                    contact = value;
                    RaisePropertyChanged("Contact");
                }
            }
        }

        private List<int> roomsReserved;
        public List<int> RoomsReserved
        {
            get { return roomsReserved; }
            set
            {
                if (roomsReserved != value)
                {
                    roomsReserved = value;
                    RaisePropertyChanged("RoomsReserved");
                }
            }
        }
        private string specialRequest;
        public string SpecialRequest
        {
            get { return specialRequest; }
            set
            {
                if (specialRequest != value)
                {
                    specialRequest = value;
                    RaisePropertyChanged("SpecialRequest");
                }
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    RaisePropertyChanged("Email");
                }
            }
        }     

        private ICollection<Reservation> bookings; 
        public virtual ICollection<Reservation> Bookings 
        {
            get
            {
                return bookings;
            }
            set
            {
                bookings = value;
                RaisePropertyChanged("Bookings");
            }
        }
    }
}
