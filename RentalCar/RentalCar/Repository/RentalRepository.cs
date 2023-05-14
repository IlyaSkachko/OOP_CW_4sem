using RentalCar.DataBase;
using RentalCar.DTO;
using RentalCar.Model;
using RentalCar.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Repository
{
    public class RentalRepository : IRentalRepository
    {
        public void CancelOrder(string login)
        {
            var profRep = new ProfileRepository();
            var profileId = profRep.SearchProfileId(login);

            using (var context= new MyDBContext())
            {
                var rental = context.RentalApplications.Where(rental => rental.ProfileID == profileId).Single();
                if (rental != null)
                {
                    context.RentalApplications.Remove(rental);
                    context.SaveChanges();
                }
            }
        }

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

        public bool CheckOrderByCarId(int carId)
        {
            using (var context = new MyDBContext())
            {
                var list = context.RentalApplications.Where(order => order.CarID == carId);

                if (list.Count() > 0)
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
                var ren = new RentalApplications() { RentalPeriod = period, CarID = carId, ProfileID = profileID, DateRentalCar = date, Status = "Ожидание" };

                context.RentalApplications.Add(ren);
                context.SaveChanges();
            }
        }

        public ObservableCollection<CarItemModel> GetRentalCar(string login)
        {
            using (var context = new MyDBContext())
            {
                var profRep = new ProfileRepository();
                var carRep = new CarRepository();
                int carId = 0;
                var profileId = profRep.SearchProfileId(login);
                var rental = context.RentalApplications.Where(rental => rental.ProfileID == profileId).FirstOrDefault();

                if (rental != null)
                {
                    carId = rental.CarID;
                }
                return carRep.SearchRentalCar(carId);
            }

        }

        public bool IsOrderApproved(string login)
        {
            using (var context = new MyDBContext())
            {
                var profRep = new ProfileRepository();

                var userID = profRep.SearchProfileId(login);

                var user = context.RentalApplications.Where(rental => rental.ProfileID == userID).FirstOrDefault();

                if (user != null)
                {
                    if (user.Status.Equals("Одобрено"))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
