using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Hotel.Monitor.Entities
{
    public class RoomPrice : Notifier
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

        private RoomType rType;


        //public int RoomType_Id { get; set; }

        // [ForeignKey("RoomType_Id")]
        [Required]
        public virtual RoomType RoomType
        {
            get
            {
                return rType;
            }
            set
            {
                rType = value;
                RaisePropertyChanged("RoomType");
            }
        }

        private DateTime dtFrom = DateTime.Today;

        public DateTime FromDate
        {
            get
            {
                return dtFrom;
            }
            set
            {
                dtFrom = value;
                RaisePropertyChanged("FromDate");
            }
        }


        private DateTime dtTo = DateTime.Today;

        public DateTime ToDate
        {
            get
            {
                return dtTo;
            }
            set
            {
                dtTo = value;
                RaisePropertyChanged("ToDate");
            }
        }

        private decimal rate;
        public decimal Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
                RaisePropertyChanged("Rate");
            }
        }
    }
}
