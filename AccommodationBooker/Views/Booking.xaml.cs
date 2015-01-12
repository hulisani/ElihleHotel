using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AccommodationBooker.ViewModels;
using Hotel.Monitor.Entities;

namespace AccommodationBooker.Views
{
    /// <summary>
    /// Interaction logic for Booking.xaml
    /// </summary>
    public partial class Booking : Window
    {
        private BookingVM bookingVM;
        public Booking(Reservation reservation)
        {
            bookingVM = new BookingVM(reservation);
            this.DataContext = bookingVM;
            InitializeComponent();
        }
    }
}
