using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AccommodationBooker.Commands
{
    public class DelegateCommand : ICommand
    {
        public DelegateCommand(Action executeMethod)
        {
            _executeMethod = executeMethod;
        }

        private Action _executeMethod;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _executeMethod.Invoke();
        }
    }
}
