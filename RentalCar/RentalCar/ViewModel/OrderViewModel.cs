using RentalCar.DataBase;
using RentalCar.DTO;
using RentalCar.Model;
using RentalCar.Repository;
using RentalCar.View.Order;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RentalCar.ViewModel
{
    public class OrderViewModel : BaseViewModel
    {


        public ObservableCollection<OrderModel> OrderItems { get; set; }

        public OrderViewModel()
        {
            OrderItems = new ObservableCollection<OrderModel> { };
            OrderItems = GetOrders();
        }

        private ObservableCollection<OrderModel> GetOrders()
        {
            var orders = new ObservableCollection<OrderModel>();

            var profiles = GetProfiles();
            var cars = GetCars();

            if (profiles.Count > 0 && cars.Count() > 0) 
            {
                for (var i = 0; i < profiles.Count(); i++)
                {
                    orders.Add(GetOrder(cars[i].Model, profiles[i].Login));
                }
            }

            return orders;
        }


        private List<Profile> GetProfiles()
        {
            using (var context = new MyDBContext())
            {
                var profiles = (from ra in context.RentalApplications
                                join c in context.Profiles on ra.ProfileID equals c.Id
                                select c).Distinct().ToList();
                return profiles;
            }
        }


        private List<Car> GetCars()
        {
            using (var context = new MyDBContext())
            {
                var cars = (from ra in context.RentalApplications
                            join c in context.Cars on ra.CarID equals c.Id
                            select c).Distinct().ToList();

                return cars;
            }
        }


        private OrderModel GetOrder(string model, string login)
        {
            var order = new OrderModel()
            {
                Model = model,
                Login = login
            };

            return order;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static void AcceptOrder(OrderModel orderModel)
        {
            using (var context = new MyDBContext())
            {
                var rep = new ProfileRepository();
                var id = rep.SearchProfileId(orderModel.Login);
                var rent = context.RentalApplications.Where(rent => rent.ProfileID == id).FirstOrDefault();
                if (rent != null)
                {
                    rent.Status = "Одобрено";
                    MessageBox.Show("Аренда одобрена!");
                }
                context.SaveChanges();
            }
        }        
        public static void DeleteOrder(OrderModel deleteModel)
        {
            using (var context = new MyDBContext())
            {
                var rep = new ProfileRepository();
                var id = rep.SearchProfileId(deleteModel.Login);
                var rent = context.RentalApplications.Where(rent => rent.ProfileID == id).FirstOrDefault();
                if (rent != null)
                {
                    context.RentalApplications.Remove(rent);
                    MessageBox.Show("Аренда отклонена!");
                }
                context.SaveChanges();
            }
        }

    }
}
