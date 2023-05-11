using RentalCar.DTO;
using RentalCar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.ViewModel
{
    public class ProfileViewModel : INotifyPropertyChanged
    {

        private ProfileModel profile = new ProfileModel();
        public string Name { get => profile.Name; set { profile.Name = value; OnPropertyChanged("Name"); } }
        public string Passport { get => profile.Passport; set { profile.Passport = value; OnPropertyChanged("Passport"); } }
        public string CardNumber { get => profile.CardNumber; set { profile.CardNumber = value; OnPropertyChanged("CardNumber"); } }
        public string Login { get => profile.Login; set { profile.Login = value; OnPropertyChanged("Login"); } }
        public ProfileViewModel()
        {
            Name = AuthorizationViewModel.Name; Passport = AuthorizationViewModel.Passport; CardNumber = AuthorizationViewModel.CardNumber; Login = AuthorizationViewModel.Login;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
