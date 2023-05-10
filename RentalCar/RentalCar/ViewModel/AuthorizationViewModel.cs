using RentalCar.Commands;
using RentalCar.DataBase;
using RentalCar.View.MainPage;
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
        private readonly ICommand openMainPageCommand;
        private NavigationService _navigationService;


        public string Login { get; set; }
        public string Password { get; set; }    

        public ICommand OpenRegistrationCommand
        {
            get { return _openRegistrationCommand; }
        }

        public ICommand OpenMainPageCommand
        {
            get { return openMainPageCommand; }
        }

        public AuthorizationViewModel() 
        {
            _openRegistrationCommand = new RelayCommand(OpenRegistration);
            openMainPageCommand = new RelayCommand(OpenMainPage);
        }

        private void OpenRegistration()
        {
            Application.Current.MainWindow.Content = new RegistrationPage();
        }

        private void OpenMainPage()
        {
            using (var context = new MyDBContext())
            {
                var user = context.Profiles.Where(profile => profile.Login.Equals(Login)).FirstOrDefault();
                if (user != null) 
                {
                    if (user.Password == Password) 
                    {
                        Application.Current.MainWindow.Content = new MainPage();
                    }
                    else
                    {
                        MessageBox.Show("Неверно введён пороль!");
                    }
                }
                else
                {
                    MessageBox.Show("Такого аккаунта не существует!");
                }
            }
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
