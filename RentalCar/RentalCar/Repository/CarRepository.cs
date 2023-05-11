using RentalCar.DataBase;
using RentalCar.DTO;
using RentalCar.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Formats.Asn1;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace RentalCar.Repository
{
    public class CarRepository : ICarRepository
    {
        private ObservableCollection<CarItemModel> _carItems = new();

        public ObservableCollection<CarItemModel> Filter(string power, string price, string carBody, string carClass, string model)
        {
            _carItems.Clear();

            bool isPower = false, isCarBody = false, isCarClass = false, isPrice = false;
            int carPrice = int.Parse(price), carPower = 0;

            bool isParseComplete = false;

            #region CheckUse
            if (carPrice > 50)
            {
                isPrice = true;

            }
            if (power != null)
            {
                isPower = true;
                isParseComplete = int.TryParse(power, out carPower);
            }
            if (carBody != "")
            {
                isCarBody = true;
            }
            if (carClass != "")
            {
                isCarClass = true;
            }

            #endregion


            #region AllFilters
            using (var context = new MyDBContext())
            {
                if (isPrice && !isPower && !isCarBody && !isCarClass)
                {
                    Price(int.Parse(price));
                }

                if (!isPrice && !isPower && isCarBody && !isCarClass)
                {
                    var list = CarBodySearch(carBody);
                    Rewrite(list);
                }                
                if (!isPrice && !isPower && !isCarBody && isCarClass)
                {
                    var list = CarClassSearch(carClass);
                    Rewrite(list);
                }
                if (isPrice && !isPower && isCarBody && !isCarClass)
                {
                    var list = context.Cars.Where(car => car.Price <= carPrice).Where(car => car.CarBody.Equals(carBody));
                    Rewrite(list);
                }          
                if (isPrice && !isPower && isCarBody && isCarClass)
                {
                    var list = context.Cars.Where(car => car.Price <= carPrice).Where(car => car.CarBody.Equals(carBody)).Where(car=> car.Class.Equals(carClass));
                    Rewrite(list);
                }                
                if (isPrice && !isPower && !isCarBody && isCarClass)
                {
                    var list = context.Cars.Where(car => car.Price <= carPrice).Where(car=> car.Class.Equals(carClass));
                    Rewrite(list);
                }

                if (isParseComplete)
                {
                    if (!isPrice && isPower && !isCarBody && !isCarClass)
                    {
                        Power(carPower);
                    }

                    if (isPrice && isPower && !isCarBody && !isCarClass)
                    {
                        var list = context.Cars.Where(car => car.Power == carPower).Where(car => car.Price <= carPrice);
                        Rewrite(list);
                    }
                    if (isPrice && isPower && isCarBody && !isCarClass)
                    {
                        var list = context.Cars.Where(car => car.Power == carPower).Where(car => car.Price <= carPrice)
                                .Where(car => car.CarBody.Equals(carBody));
                        Rewrite(list);
                    }       
                    if (isPrice && isPower && isCarBody && isCarClass)
                    {
                        var list = context.Cars.Where(car => car.Power == carPower).Where(car => car.Price <= carPrice)
                                .Where(car => car.CarBody.Equals(carBody)).Where(car => car.Class.Equals(carClass));
                        Rewrite(list);

                    }
                    if (!isPrice && isPower && isCarBody && !isCarClass)
                    {
                        var list = context.Cars.Where(car => car.Power == carPower).Where(car => car.CarBody.Equals(carBody));
                        Rewrite(list);
                    }
                    if (!isPrice && isPower && !isCarBody && isCarClass)
                    {
                        var list = context.Cars.Where(car => car.Power == carPower).Where(car => car.Class.Equals(carClass));
                        Rewrite(list);
                    }
                    if (!isPrice && isPower && isCarBody && isCarClass)
                    {
                        var list = context.Cars.Where(car => car.Power == carPower).Where(car => car.Class.Equals(carClass)).Where(car => car.CarBody.Equals(carBody));
                        Rewrite(list);
                    }
                }

                if (!isPrice && !isPower && isCarBody && isCarClass)
                {
                    var list = context.Cars.Where(car => car.Class.Equals(carClass)).Where(car => car.CarBody.Equals(carBody));
                    Rewrite(list);
                }
            }

            #endregion

            return _carItems;
        }

        private void Rewrite(IEnumerable<CarItemModel> list)
        {
            _carItems.Clear();
            foreach (var item in list)
            {
                _carItems.Add(item);
            }
        }

        private void Rewrite(IQueryable<Car> list)
        {
            _carItems.Clear();
            foreach (var item in list)
            {
                _carItems.Add(Create(item));
            }
        }

        private void Rewrite( ObservableCollection<CarItemModel> list)
        {
            _carItems.Clear();
            foreach (var item in list)
            {
                _carItems.Add(item);
            }
        }


        private ObservableCollection<CarItemModel> CarBodySearch(string body)
        {
            var carItems = new ObservableCollection<CarItemModel>();
            using (var context = new MyDBContext())
            {
                foreach (var car in context.Cars)
                {
                    if (car.CarBody == body)
                    {
                        carItems.Add(Create(car));
                    }
                }
            }

            return carItems;
        }

        private ObservableCollection<CarItemModel> CarClassSearch(string carClass)
        {
            var carItems = new ObservableCollection<CarItemModel>();
            using (var context = new MyDBContext())
            {
                foreach (var car in context.Cars)
                {
                    if (car.Class == carClass)
                    {
                        carItems.Add(Create(car));
                    }
                }
            }

            return carItems;
        }

        

        public ObservableCollection<CarItemModel> ModelSearch(string model)
        {
            _carItems.Clear();
            using (var context = new MyDBContext())
            {
                var regex = new Regex(model, RegexOptions.IgnoreCase);
                foreach (var car in context.Cars)
                {
                    if (regex.IsMatch(car.Model))
                    {
                        _carItems.Add(Create(car));
                    }
                }
            }

            return _carItems;
        }

        private ObservableCollection<CarItemModel> Power(int power)
        {
            using (var context = new MyDBContext())
            {
                foreach (var car in context.Cars)
                {
                    if (car.Power == power)
                    {
                        _carItems.Add(Create(car));
                    }
                }
            }

            return _carItems;
        }

        private ObservableCollection<CarItemModel> Price(int price)
        {
            using (var context = new MyDBContext())
            {
                foreach (var car in context.Cars)
                {
                    if (car.Price <= price)
                    {
                        _carItems.Add(Create(car));
                    }
                }
            }

            return _carItems;
        }

        public ObservableCollection<CarItemModel> ShowAll()
        {
            _carItems.Clear();
            using (var context = new MyDBContext())
            {
                foreach(var item in context.Cars)
                {
                    _carItems.Add(Create(item));
                }
                return _carItems;
            }
        }

        private CarItemModel Create(Car item)
        {
            var carItemModel = new CarItemModel()
            {
                Model = item.Model,
                CarBody = item.CarBody,
                CarClass = item.Class,
                Power = item.Power + " л.с.",
                Price = item.Price + " BYN/сут.",
                Image = @"C:\Users\ilyas\Documents\UNIVER\CourseWork\RentalCar\RentalCar\Images\" + item.Photo,
                Description = item.Description,
                Capacity = "Вместимость: " + item.Capacity.ToString(),
                FuelConsumption = item.FuelConsumption + "л/100 км"
            };

            return carItemModel;
        }

        public int SearchCarID(CarItemModel car)
        {
            int id = 0;
            using (var context = new MyDBContext())
            {
                id = context.Cars.Where(c => c.Model.Equals(car.Model)).Where(c => c.Class.Equals(car.CarClass)).First().Id;
            }

            return id;
        }
    }
}
