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
    public class RegistrationViewModel : BaseViewModel
    {

        private readonly ICommand _registrationCommand;
        private readonly ICommand exitFormCommand;


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
        public ICommand ExitFormCommand
        {
            get { return exitFormCommand; }
        }

        public RegistrationViewModel()
        {
            _registrationCommand = new RelayCommand(Navigate);
            exitFormCommand = new RelayCommand(() => { Application.Current.MainWindow.Content = new Authorization(); });
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
            else
            {
                MessageBox.Show("Введите корректные данные!");
                return false;
            }
        }

        private bool CheckFio()
        {
            if (FIO != null)
            {
                if (FIO.Length > 5)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Неверный ввод ФИО");
                    return false;
                }
            }
            return false;

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
                    MessageBox.Show("Пароли не совпадают");
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
                        MessageBox.Show("Аккаунт с таким логином уже существует! Придумайте другой");
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Слишком короткий логин!");
                return false;
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
