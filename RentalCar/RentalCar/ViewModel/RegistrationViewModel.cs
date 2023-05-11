using RentalCar.Commands;
using RentalCar.DataBase;
using RentalCar.DTO;
using RentalCar.View;
using RentalCar.View.Registration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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


        public string FIO { get; set; }
        public string Password { get; set; }
        public string PasswordAgain { get; set; }

        public string Passport { get; set; }
        public string CardNumber { get; set; }
        public string Login { get; set; }


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
            if (CheckAllInfo())
            {
                WriteDBInfo();
                Application.Current.MainWindow.Content = new Authorization();
            }
        }

        private void WriteDBInfo()
        {
            using (var context = new MyDBContext())
            {
                var user = new User() { CardNumber = CardNumber, Name = FIO, Passport = Passport };
                Profile profile;
                var users = context.Users.Where(user => user.Passport.Equals(Passport));
                if (users.Count() == 0)
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                    profile = new Profile() { Login = Login, Password = Password, UserID = user.Id };
                }
                else
                {
                    profile = new Profile() { Login = Login, Password = Password, UserID = users.ToList()[0].Id };
                }
                context.Profiles.Add(profile);
                context.SaveChanges();
            }
        }

        private bool CheckAllInfo()
        {
            if (CheckFio() && CheckLogin() && CheckPassword() && CheckPassport() && CheckCardNumber())
            {
                return true;
            }
            return false;
        }

        private bool CheckFio()
        {
            if (FIO.Length != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Неверный ввод ФИО");
                return false;
            }

        }

        private bool CheckPassword()
        {
            if (Password != null && Password.Length >= 8)
            {
                if (Password.Equals(PasswordAgain))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Пороли не совпадают");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Слишком корткий пороль");
                return false;
            }
        }

        private bool CheckPassport()
        {
            if (Passport != null && Passport.Length == 9)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Неверно введен паспорт");
                return false;
            }

        }

        private bool CheckCardNumber()
        {
            if (Passport != null && CardNumber.Length == 16)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Неверно введен номер карты");
                return false;
            }
        }

        private bool CheckLogin()
        {
            if (Login != null && Login.Length >= 6)
            {
                using (var context = new MyDBContext())
                {
                    var loginList = context.Profiles.Where(profile => profile.Login.Equals(Login));
                    if (loginList.Count() == 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Такой логин уже существует! Придумайте другой");
                        return false;
                    }
                }
            }
            return false;
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
