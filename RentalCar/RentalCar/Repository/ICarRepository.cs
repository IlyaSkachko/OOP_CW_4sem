using RentalCar.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Repository
{
    public interface ICarRepository
    {
        ObservableCollection<CarItemModel> Filter(string power, string price, string carBody, string carClass, string model);
        ObservableCollection<CarItemModel> ModelSearch(string model);

        int SearchCarID(CarItemModel car);
        ObservableCollection<CarItemModel> SearchRentalCar(int carId);

        void DeleteCar(int carId);
    }
}
