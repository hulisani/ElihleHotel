using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Monitor.Entities
{
    public class HotelRoom : Notifier
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

        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                RaisePropertyChanged("Description");
            }
        }

        [NotMapped]
        public decimal Price
        {
            get
            {
                if (RoomType != null && RoomType.RoomPrices != null)
                {
                    var prices = RoomType.RoomPrices.Where(p => p.FromDate <= DateTime.Today && p.ToDate >= DateTime.Today).OrderByDescending(pr => pr.FromDate);
                    var price = prices.FirstOrDefault();
                    if (price != null)
                        return price.Rate;
                }
                return 0;
            }
        }

        private RoomType roomType;

        public virtual RoomType RoomType
        {
            get
            {
                return roomType;
            }
            set
            {
                roomType = value;
                RaisePropertyChanged("RoomType");
            }
        }

        
        private Reservation activeBooking;
        public virtual Reservation ActiveBooking
        {
            get
            {
                return activeBooking;
            }
            set
            {
                activeBooking = value;
                RaisePropertyChanged("ActiveBooking");
            }
        }

        private int maxPeopleInRoom;
        public int MaxPeople
        {
            get
            {
                return maxPeopleInRoom;
            }
            set
            {
                maxPeopleInRoom = value;
                RaisePropertyChanged("MaxPeople");
            }
        }
        
        public bool IsBooked
        {
            get
            {
                return ActiveBooking == null;
            }
        }
    }
}
