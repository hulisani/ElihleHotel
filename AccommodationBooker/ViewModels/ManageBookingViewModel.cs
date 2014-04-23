
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccommodationBooker.ViewModels
{
    public class ManageBookingViewModel : INotifyPropertyChanged
    {
        public ManageBookingViewModel()
        {
            
        }

        private List<Hotel.Monitor.Entities.Reservation> fullReservationList;
        public List<Hotel.Monitor.Entities.Reservation> FullReservationList
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
