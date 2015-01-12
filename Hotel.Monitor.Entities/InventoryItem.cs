using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Monitor.Entities
{
    public class InventoryItem : Notifier
    {

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                RaisePropertyChanged("Name");
            }
        }

        private string code;

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
    }
}
