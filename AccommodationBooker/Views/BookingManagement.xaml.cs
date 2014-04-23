using AccommodationBooker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AccommodationBooker.Views
{
    /// <summary>
    /// Interaction logic for BookingManagement.xaml
    /// </summary>
    public partial class BookingManagement : Page
    {
        private ManageBookingViewModel viewModel;

        public BookingManagement()
        {
            viewModel = new ManageBookingViewModel();
            this.DataContext = viewModel;

            InitializeComponent();
        }
    }
}
