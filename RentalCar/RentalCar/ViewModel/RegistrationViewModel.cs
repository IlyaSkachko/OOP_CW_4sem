using RentalCar.Commands;
using RentalCar.View;
using RentalCar.View.Registration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace RentalCar.ViewModel
{
    public class RegistrationViewModel : INotifyPropertyChanged
    {
        private readonly ICommand _registrationCommand;
        private NavigationService _navigationService;

        public ICommand RegistrationCommand
        {
            get { return _registrationCommand; }
        }

        public RegistrationViewModel()
        {
            _registrationCommand = new RelayCommand(Navigate);
        }

        private void Navigate()
        {
            Application.Current.MainWindow.Content = new Authorization();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
