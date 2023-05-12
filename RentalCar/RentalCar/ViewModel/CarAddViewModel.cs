using RentalCar.Commands;
using RentalCar.Model;
using RentalCar.Repository;
using RentalCar.View.AddCar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RentalCar.ViewModel
{
    public class CarAddViewModel : INotifyPropertyChanged
    {

        #region Commands

        private ICommand carAddCommand;
        private ICommand selectPhotoCommand;


        public ICommand CarAddCommand { get { return carAddCommand; } }
        public ICommand SelectPhotoCommand { get { return selectPhotoCommand; } }

        #endregion

        #region FieldAndProperties

        private string model;
        private string power;
        private string price;
        private string carBody;
        private string carClass;
        private string image;
        private string capacity;
        private string fuelConsumption;
        private string description;
        private string color;

        public string Color
        {
            get => color;
            set { color = value; OnPropertyChanged(nameof(color)); }
        }

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
            set { model = value; OnPropertyChanged("Model"); }
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

        #endregion


        public CarAddViewModel()
        {
            carAddCommand = new ChangeCommand(AddCar);
            selectPhotoCommand = new ChangeCommand(SelectPhoto);
        }

        private void SelectPhoto()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            dlg.Title = "Select an image file";

            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                string selectedPath = dlg.FileName;
                Image = selectedPath;
            }
        }

        private void AddCar()
        {
            CarItemModel car = new();
            int carCapacity, carPower, carPrice;

            float fuel;
            
            if (model.Length != null && carClass.Length != null && carBody.Length != null && capacity.Length != null && fuelConsumption.Length != null && power.Length != null && 
                description.Length != null && price.Length != null && image.Length != null)
            {
                if (int.TryParse(capacity, out carCapacity) && int.TryParse(power, out carPower) && int.TryParse(price, out carPrice) && float.TryParse(fuelConsumption, out fuel)
                    && CheckClass() && CheckBody() && carCapacity > 0 && carPower > 0 && carPrice > 0 && fuel > 0)
                {
                    car.Price = price;
                    car.Power = power;
                    car.Capacity = capacity;
                    car.CarClass = carClass;
                    car.CarBody = carBody;
                    car.FuelConsumption = fuelConsumption;
                    car.Model = model;
                    car.Description = description;
                    car.Image = image;

                    var rep = new CarRepository();
                    rep.AddCar(car);

                    MessageBox.Show("Автомобиль добавлен!");
                }
                else
                {
                    MessageBox.Show("Введены некорректные данные!");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
            
        private bool CheckClass()
        {
            if (carClass == "Комфорт" || carClass == "Спорт" || carClass == "Бизнес" || carClass == "Эконом")
            {
                return true;
            }
            return false;
        }
        private bool CheckBody()
        {
            if (carBody == "Внедорожник" || carBody == "Седан" || carBody == "Кабриолет" || carBody == "Минивен" )
            {
                return true;
            }
            return false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
