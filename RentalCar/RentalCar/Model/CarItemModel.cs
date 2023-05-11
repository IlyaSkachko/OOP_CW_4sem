using RentalCar.Commands;
using RentalCar.Repository;
using RentalCar.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace RentalCar.Model
{
    public class CarItemModel : INotifyPropertyChanged
    {
        private string model;
        private string power;
        private string price;
        private string carBody;
        private string carClass;
        private string image;
        private string capacity;
        private string fuelConsumption;
        private string description;


        public string Capacity
        {
            get => capacity;
            set { capacity = value; OnPropertyChanged("Capacity"); }
        }

        public string FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; OnPropertyChanged("FuelConsumption"); }
        }

        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged("Description"); }
        }

        public string Image
        {
            get { return image; }
            set { image = value; OnPropertyChanged("Image"); }
        }

        public string Model
        {
            get { return model; }
            set { model = value;  OnPropertyChanged("Model"); }
        }

        public string Power
        {
            get { return power; }
            set { power = value; OnPropertyChanged("Power"); }
        }

        public string Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged("Price"); }
        }

        public string CarBody
        {
            get { return carBody; }
            set
            {
                carBody = value; OnPropertyChanged("CarBody");
            }
        }

        public string CarClass
        {
            get { return carClass; }
            set { carClass = value; OnPropertyChanged("CarClass"); }
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
            return obj is CarItemModel model &&
                   this.model == model.model &&
                   power == model.power &&
                   price == model.price &&
                   carBody == model.carBody &&
                   carClass == model.carClass &&
                   image == model.image &&
                   capacity == model.capacity &&
                   fuelConsumption == model.fuelConsumption &&
                   description == model.description &&
                   Capacity == model.Capacity &&
                   FuelConsumption == model.FuelConsumption &&
                   Description == model.Description &&
                   Image == model.Image &&
                   Model == model.Model &&
                   Power == model.Power &&
                   Price == model.Price &&
                   CarBody == model.CarBody &&
                   CarClass == model.CarClass &&
                   EqualityComparer<IEnumerable>.Default.Equals(carItems, model.carItems) &&
                   EqualityComparer<IEnumerable>.Default.Equals(CarItems, model.CarItems);
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(model);
            hash.Add(power);
            hash.Add(price);
            hash.Add(carBody);
            hash.Add(carClass);
            hash.Add(image);
            hash.Add(capacity);
            hash.Add(fuelConsumption);
            hash.Add(description);
            hash.Add(Capacity);
            hash.Add(FuelConsumption);
            hash.Add(Description);
            hash.Add(Image);
            hash.Add(Model);
            hash.Add(Power);
            hash.Add(Price);
            hash.Add(CarBody);
            hash.Add(CarClass);
            hash.Add(carItems);
            hash.Add(CarItems);
            return hash.ToHashCode();
        }

        private readonly ICommand openModalCommand;
        public ICommand OpenModalCommand { get => openModalCommand; }

        public ICommand CancelOrderCommand { get => cancelOrderCommand; }
        private ICommand cancelOrderCommand;
        public CarItemModel()
        {
            cancelOrderCommand = new OrderCommand(CancelOrder);
            openModalCommand = new RelayCommand(() => { ModalWindowViewModel.CarID = new CarRepository().SearchCarID(this); new ModalWindow().ShowDialog(); });
        }

        private void CancelOrder()
        {
            var rep = new RentalRepository();

            rep.CancelOrder(AuthorizationViewModel.Login);

            ProfileViewModel.CarItems.Clear();
        }

        private System.Collections.IEnumerable carItems;

        public System.Collections.IEnumerable CarItems { get => carItems; set => SetProperty(ref carItems, value); }


    }
}
