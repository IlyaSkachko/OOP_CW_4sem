using RentalCar.DataBase;
using RentalCar.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Repository
{
    public class RentalRepository : IRentalRepository
    {
        // пофиксить (не все ситуации обрабатывает)


        public bool CheckAvailableCar(int carID, DateTime date, int period)
        {
            using (var context = new MyDBContext())
            {
                var list = context.RentalApplications.Where(car => car.CarID == carID);

                if (list.Count() > 0) {
                    list = list.OrderBy(car => car.DateRentalCar);
                    foreach (var item in list)
                    {

                        if (date.AddDays(period) < item.DateRentalCar)
                        {
                            return true;
                        }
                        else if (date >= item.DateRentalCar)
                        {
                            if (date > item.DateRentalCar.AddDays(item.RentalPeriod))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public bool CheckAvailableOrder(string login)
        {
            using (var context = new MyDBContext())
            {
                var profile = context.Profiles.Where(profile => profile.Login.Equals(login)).FirstOrDefault();
                var count = context.RentalApplications.Where(user => user.ProfileID == profile.Id).Count();
                if (count == 0)
                {
                    return true;
                }
                return false;
            }
        }

        public void CreateRentalApplication(int profileID, int carId, DateTime date, int period)
        {
            using (var context = new MyDBContext())
            {
                var ren = new RentalApplications() { RentalPeriod = period, CarID = carId, ProfileID = profileID, DateRentalCar = date };

                context.RentalApplications.Add(ren);
                context.SaveChanges();
            }
        }
    }
}
