using RentalCar.DataBase;
using RentalCar.DTO;
using RentalCar.View;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using System.Drawing.Imaging;

namespace RentalCar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AuthorizationFrame.Content = new Authorization();


            #region CreateDB

            //using (var context = new MyDBContext())
            //{
            //    List<Car> cars = new List<Car>()
            //    {
            //        new Car() { Model = "BMW 5 G30", Capacity = 5, Class = "Бизнес", Color = "Чёрный", CarBody = "Седан",
            //                    Description = "Автомобиль с малым расходом топлива и шустрый, то что нужно для города", FuelConsumption=8.3f, Power = 300, Price=280,
            //                    Photo=File.ReadAllBytes("Cars/BMW5.jpeg")},
            //        new Car() { Model = "Volkswagen Polo", Capacity = 5, Class = "Эконом", Color = "Чёрный", CarBody = "Седан",
            //                    Description = "Экономичный и простой автомобиль", FuelConsumption=9.5f, Power = 90, Price=55,
            //                    Photo=File.ReadAllBytes("Cars/VWPolo.jpeg")},
            //        new Car() { Model = "Volkswagen Eos", Capacity = 4, Class = "Комфорт", Color = "Белый", CarBody = "Кабриолет",
            //                    Description = "Летом в жару сказка", FuelConsumption=11f, Power = 140, Price=96,
            //                    Photo=File.ReadAllBytes("Cars/VWEos.jpeg")},
            //        new Car() { Model = "BMW 4 series", Capacity = 4, Class = "Комфорт", Color = "Чёрный", CarBody = "Кабриолет",
            //                    Description = "Летом в жару сказка", FuelConsumption=10f, Power = 250, Price=320,
            //                    Photo=File.ReadAllBytes("Cars/BMW4.jpeg")},
            //        new Car() { Model = "Audi Q7", Capacity = 5, Class = "Комфорт", Color = "Чёрный",
            //                    Description = "Большому дяде большая машина", FuelConsumption=12.4f, Power = 300, Price=355,
            //                    Photo=File.ReadAllBytes("Cars/AudiQ7.jpeg")},
            //        new Car() { Model = "Jeep Compass", Capacity = 5, Class = "Комфорт", Color = "Серый",
            //                    Description = "Большому дяде большая машина", FuelConsumption=15.4f, Power = 256, Price=280,
            //                    Photo=File.ReadAllBytes("Cars/JEEPCompass.jpeg")},
            //        new Car() { Model = "Hyundai Staria", Capacity = 8, Class = "Комфорт", Color = "Белый",
            //                    Description = "Большой семье большой автомобиль", FuelConsumption=12.4f, Power = 256, Price=410,
            //                    Photo=File.ReadAllBytes("Cars/HyundaiStaria.jpeg")},
            //        new Car() { Model = "Citroen Grand Picasso", Capacity = 8, Class = "Комфорт", Color = "Белый",
            //                    Description = "Большой семье большой автомобиль", FuelConsumption=13.2f, Power = 190, Price=210,
            //                    Photo=File.ReadAllBytes("Cars/CitroenPicasso.jpeg")}

            //    };

            //    foreach (var car in cars)
            //    {
            //        context.Cars.Add(car);
            //    }
            //    context.SaveChanges();
            //}

            #endregion
        }
    }
}
