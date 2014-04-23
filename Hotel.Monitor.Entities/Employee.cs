using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Monitor.Entities
{
    public class Employee : Notifier
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
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                RaisePropertyChanged("FirstName");
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

        private string userName;
        public string UserName 
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
                RaisePropertyChanged("UserName");
            }
        }

        private string password;
        public string Password 
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
                RaisePropertyChanged("Password");
            }
        }

        private string idNumber;
        public string IdNumber 
        {
            get
            {
                return idNumber;
            }
            set
            {
                idNumber = value;
                RaisePropertyChanged("IdNumber");
            }
        }

        private DateTime dateOfEmployment;
        public DateTime StartDateOfEmployment
        {
            get
            {
                return dateOfEmployment;
            }
            set
            {
                dateOfEmployment = value;
                RaisePropertyChanged("StartDateOfEmployment");
            }
        }


    }
}
