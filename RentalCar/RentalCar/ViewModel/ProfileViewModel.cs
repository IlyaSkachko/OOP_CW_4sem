using RentalCar.Commands;
using RentalCar.DTO;
using RentalCar.Model;
using RentalCar.Repository;
using RentalCar.View;
using RentalCar.View.MainPage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity.Core.Objects.DataClasses;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace RentalCar.ViewModel
{
    public class ProfileViewModel : BaseViewModel, INotifyPropertyChanged
    {


        #region ProfileData

        private ProfileModel profile = new ProfileModel();
        public string Name { get => profile.Name; set { profile.Name = value; OnPropertyChanged("Name"); } }
        public string Passport { get => profile.Passport; set { profile.Passport = value; OnPropertyChanged("Passport"); } }
        public string CardNumber { get => profile.CardNumber; set { profile.CardNumber = value; OnPropertyChanged("CardNumber"); } }
        public string Login { get => profile.Login; set { profile.Login = value; OnPropertyChanged("Login"); } }

        #endregion

        private ICommand openMainPageCommand;
        private ICommand exitAccountCommand;


        public ICommand OpenMainPageCommand { get => openMainPageCommand; }
        public ICommand ExitAccountCommand { get => exitAccountCommand; }

        public static ObservableCollection<CarItemModel> CarItems { get; set; }


        public ProfileViewModel()
        {
            CarItems = new ObservableCollection<CarItemModel> { };
            var rep = new RentalRepository();
            CarItems = rep.GetRentalCar(AuthorizationViewModel.Login);

            Name = AuthorizationViewModel.Name; Passport = AuthorizationViewModel.Passport; CardNumber = AuthorizationViewModel.CardNumber; Login = AuthorizationViewModel.Login;
            openMainPageCommand = new RelayCommand(() => { Application.Current.MainWindow.Content = new MainPage(); });
            exitAccountCommand = new RelayCommand(() => { Application.Current.MainWindow.Content = new Authorization(); });

        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
