using RentalCar.Commands;
using RentalCar.View.Registration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace RentalCar.ViewModel
{
    public class AuthorizationViewModel : INotifyPropertyChanged
    {

        private readonly ICommand _openRegistrationCommand;
        private NavigationService _navigationService;

        public ICommand OpenRegistrationCommand
        {
            get { return _openRegistrationCommand; }
        }

        public AuthorizationViewModel() 
        {
            _openRegistrationCommand = new RelayCommand(Navigate);
        }

        private void Navigate()
        {
            Application.Current.MainWindow.Content = new RegistrationPage();
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
