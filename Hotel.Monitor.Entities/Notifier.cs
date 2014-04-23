using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Hotel.Monitor.Entities
{
    
    public abstract class Notifier : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public Notifier()
        {
           
        }

        protected void RaisePropertyChanged(string propertyName)
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
