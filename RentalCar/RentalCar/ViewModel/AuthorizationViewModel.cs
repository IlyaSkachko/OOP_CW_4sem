using RentalCar.Commands;
using RentalCar.DataBase;
using RentalCar.DTO;
using RentalCar.Model;
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
    public class AuthorizationViewModel : BaseViewModel
    {

        public static string Name { get; private set; }
        public static string Passport { get; private set; }
        public static string CardNumber { get; private set; }
        public static string Login { get; set; }

        private readonly ICommand _openRegistrationCommand;
        private readonly ICommand openMainPageCommand;
        private NavigationService _navigationService;

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
                        InitAccount(user);
                    }
                    else
                    {
                        MessageBox.Show("Неверно введён пороль!");
                    }
                }
                else if (Login != null)
                {
                    if (Login == "")
                    {
                        MessageBox.Show("Заполните поля!");
                    }
                    if (Login.Equals("admin"))
                    {
                        if (Password == "12345678")
                        {
                            Application.Current.MainWindow.Content = new MainPageAdmin();
                            InitAdmin();
                        }
                        else
                        {
                            MessageBox.Show("Неверно введён пороль!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Такого аккаунта не существует!");
                }
            }
        }



        private void InitAccount(Profile user)
        {
            using (var context = new MyDBContext())
            {
                UserModel us = new UserModel();
                var profile = context.Users.Where(prof => prof.Id == user.Id).FirstOrDefault();
                Login = user.Login;
                Name = profile.Name;
                CardNumber = profile.CardNumber;
                Passport = profile.Passport;

            }
        }

        private void InitAdmin()
        {
            Login = "admin";
        }


    }
}
