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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private LoginViewModel viewModel;

        public LoginWindow()
        {
            viewModel = new LoginViewModel(this);
            this.DataContext = viewModel;
            InitializeComponent();
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(viewModel.LoginPassed == true)
            {
                e.Cancel = false;
            }
            else if (viewModel.LoginPassed == false)
            {
                e.Cancel = true;                
            }
            else
            {
                App.Current.Shutdown();
            }          
        }
    }
}
