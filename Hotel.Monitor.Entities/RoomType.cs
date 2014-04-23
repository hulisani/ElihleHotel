using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Monitor.Entities
{
    public class RoomType : Notifier
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

        private string rType;
        public string HotelRoomType
        {
            get
            {
                return rType;
            }
            set
            {
                rType = value;
                RaisePropertyChanged("HotelRoomType");
            }
        }


        private ICollection<RoomPrice> prices;
        public virtual ICollection<RoomPrice> RoomPrices
        {
            get
            {
                return prices;
            }
            set
            {
                prices = value;
                RaisePropertyChanged("RoomPrices");
            }
        }

    }
}
