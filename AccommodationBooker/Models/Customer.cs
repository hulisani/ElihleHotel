using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccommodationBooker.Models
{
     class Customer : INotifyPropertyChanged
    {
        public Customer()
        {
            this.RoomsReserved = new List<int>();
        }
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    RefreshChangedProperties();
                }
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
                    RefreshChangedProperties();
                }
            }
        }

        private string surname;
        public string Surname
        {
            get { return surname; }
            set
            {
                if (surname != value)
                {
                    surname = value;
                    RefreshChangedProperties();
                }
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
                    RefreshChangedProperties();
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
                    RefreshChangedProperties();
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
                    RefreshChangedProperties();
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
                    RefreshChangedProperties();
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
                    RefreshChangedProperties();
                }
            }
        }

        public void RefreshChangedProperties()
        {
            RaisePropertyChanged("SpecialRequest");
            RaisePropertyChanged("RoomsReserved");
            RaisePropertyChanged("Email");
            RaisePropertyChanged("Contact");
            RaisePropertyChanged("Title");
            RaisePropertyChanged("FirstName");
            RaisePropertyChanged("Surname");
            RaisePropertyChanged("Nationality");
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
