using AccommodationBooker.Commands;
using AccommodationBooker.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Hotel.Monitor.BLL;

namespace AccommodationBooker.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged 
    {
        public LoginViewModel(LoginWindow window)
        {
            this._window = window;
            LoginPassed = null;

            EmployeeBase eb = new EmployeeBase();
            Employees = eb.GetEmployees();

            //Employees = new List<Hotel.Monitor.Entities.Employee>()
            //{
            //    new Hotel.Monitor.Entities.Employee { FirstName = "Linda", Surname = "Mnguni", Id = 1, IdNumber = "8202105350080", Password = "Tazz", StartDateOfEmployment = new DateTime(2011, 8, 24), UserName = "Lindam"}
            //};

            this.loginCommand = new DelegateCommand(AuthenticateUser);
        }

        public bool? LoginPassed;
        private LoginWindow _window;

        private void AuthenticateUser()
        {
            var employee = Employees.FirstOrDefault(x => x.UserName == this.UserName && x.Password == this.Password);
            if(employee != null)
            {
                this.LoginPassed = true;
                this._window.Close();
            }
            else
            {
                LoginFailureMessage = "The credentials entered are incorrect!";
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
                if (userName != value)
                {
                    userName = value;
                    RaisePropertyChanged("UserName");
                }
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
                if (password != value)
                {
                    password = value;
                    RaisePropertyChanged("Password");
                }
            }
        }

        private ICollection<Hotel.Monitor.Entities.Employee> employees;
        public ICollection<Hotel.Monitor.Entities.Employee> Employees
        {
            get
            {
                return employees;
            }
            set
            {
                if (employees != value)
                {
                    employees = value;
                    RaisePropertyChanged("Employees");
                }
            }
        }

        private string loginFailureMessage;
        public string LoginFailureMessage
        {
            get
            {
                return loginFailureMessage;
            }
            set
            {
                if (loginFailureMessage != value)
                {
                    loginFailureMessage = value;
                    RaisePropertyChanged("LoginFailureMessage");
                }
            }
        }

        private ICommand loginCommand;
        public ICommand LoginCommand
        {
            get { return loginCommand; }
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
    }
}
