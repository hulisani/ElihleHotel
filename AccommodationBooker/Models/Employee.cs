using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccommodationBooker.Models
{
     class Employee : INotifyPropertyChanged
    {
        private int id;
        public int Id 
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
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

        private string userName;
        public string UserName 
        {
            get { return userName; }
            set
            {
                if (userName != value)
                {
                    userName = value;
                    RefreshChangedProperties();
                }
            } 
        }

        private string password;
        public string Password 
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    RefreshChangedProperties();
                }
            } 
        }

        private string idNumber;
        public string IdNumber 
        {
            get { return idNumber; }
            set
            {
                if (idNumber != value)
                {
                    idNumber = value;
                    RefreshChangedProperties();
                }
            } 
        }

        private DateTime startDateOfEmployment;
        public DateTime StartDateOfEmployment 
        {
            get { return startDateOfEmployment; }
            set
            {
                if (startDateOfEmployment != value)
                {
                    startDateOfEmployment = value;
                    RefreshChangedProperties();
                }
            } 
        }

        public void RefreshChangedProperties()
        {
            RaisePropertyChanged("Id");
            RaisePropertyChanged("FirstName");
            RaisePropertyChanged("Surname");
            RaisePropertyChanged("UserName");
            RaisePropertyChanged("Password");
            RaisePropertyChanged("IdNumber");
            RaisePropertyChanged("StartDateOfEmployment");
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
