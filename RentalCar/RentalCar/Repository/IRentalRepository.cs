using RentalCar.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Repository
{
    public interface IRentalRepository
    {
        bool CheckAvailableCar(int carID, DateTime date, int period);
        bool CheckAvailableOrder(string login);
        void CreateRentalApplication(int profileID, int carId, DateTime date, int period);

        ObservableCollection<CarItemModel> GetRentalCar(string login);
        void CancelOrder(string login);

        bool CheckOrderByCarId(int carId);
    }
}
