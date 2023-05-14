using RentalCar.Commands;
using RentalCar.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RentalCar.Model
{
    public class OrderModel : INotifyPropertyChanged
    {
        private string model;
        private string login;

        public string Model
        {
            get => model;
            set { model = value; OnPropertyChanged("Model"); }
        }

        public string Login
        {
            get { return login; }
            set { login = value; OnPropertyChanged("Login"); }
        }




        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }

        public override bool Equals(object? obj)
        {
            return obj is OrderModel model &&
                   Model == model.Model &&
                   Login == model.Login;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Model, Login);
        }

        private System.Collections.IEnumerable orderItems;

        public System.Collections.IEnumerable OrderItems { get => orderItems; set => SetProperty(ref orderItems, value); }


        private ICommand acceptCommand;
        private ICommand deleteCommand;

        public ICommand AcceptCommand { get => acceptCommand;}
        public ICommand DeleteCommand { get => deleteCommand;}


        public OrderModel()
        {
            acceptCommand = new ChangeCommand(() => { OrderViewModel.AcceptOrder(this); });
            deleteCommand = new ChangeCommand(() => { OrderViewModel.DeleteOrder(this); });
        }



    }
}
