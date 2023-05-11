using System;
using System.Collections.Generic;
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
    }
}
