using AccommodationBooker.ViewModels;
using AccommodationBooker.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AccommodationBooker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel viewModel;

        public MainWindow()
        {
            SplashScreen splash = new SplashScreen(@"images\background.jpg");
            splash.Show(true);
            Thread.Sleep(1000);

            viewModel = new MainWindowViewModel();
            this.DataContext = viewModel;

            InitializeComponent();

            InjectNewViews();

            var dialog = new LoginWindow();
            if(dialog.ShowDialog().Equals(true))
            {
                dialog.ShowDialog();
            }
        }

        private void InjectNewViews()
        {
            InventoryManagementFrame.Content = new InventoryManagement();
            BookingManagementFrame.Content = new BookingManagement();
            IncomeExpenseFrame.Content = new IncomeExpense();
            AdminFrame.Content = new Admin();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.viewModel.GetReservedRoom();
        }
    }
}
