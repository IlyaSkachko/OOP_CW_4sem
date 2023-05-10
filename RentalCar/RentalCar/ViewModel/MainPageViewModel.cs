using RentalCar.DataBase;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using RentalCar.Model;
using System.Security.AccessControl;
using System.Collections.ObjectModel;
using RentalCar.Repository;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using RentalCar.Commands;

namespace RentalCar.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {

        #region Commands

        private readonly ICommand searchCommand;
        private readonly ICommand resetCommand;

        public ICommand SearchCommand { get => searchCommand; }
        public ICommand ResetCommand { get => resetCommand; }

        #endregion

        private CarRepository carRepository = new CarRepository();

        private string sliderValue = "50";
        private string searchField = "Поиск";
        private string powerField;
        private string modelSearch;

        private bool comfortChecked;
        private bool businessChecked;
        private bool ecoChecked;
        private bool sportChecked;


        private bool minivanChecked;
        private bool offroadChecked;
        private bool sedanChecked;
        private bool convirtibleChecked;




        public string SliderValue { get { return sliderValue; } set { sliderValue = value; OnPropertyChanged("SliderValue"); } }
        public string SearchField { get { return searchField; } set { searchField = value; OnPropertyChanged("SearchField"); } }
        public string PowerField { get { return powerField; } set { powerField = value; OnPropertyChanged("PowerField"); } }
        public ObservableCollection<CarItemModel> CarItems { get; set; }

        public bool ConvirtibleChecked { get => convirtibleChecked; set { convirtibleChecked = value; OnPropertyChanged("ConvirtibleChecked"); } }
        public bool ComfortChecked { get => comfortChecked; set { comfortChecked = value; OnPropertyChanged(nameof(ComfortChecked)); } }
        public bool BusinessChecked { get => businessChecked; set { businessChecked = value; OnPropertyChanged("BusinessChecked"); } }
        public bool EcoChecked { get => ecoChecked; set { ecoChecked = value; OnPropertyChanged("EcoChecked"); } }
        public bool SportChecked { get => sportChecked; set { sportChecked = value; OnPropertyChanged("SportChecked"); } }
        public bool MinivanChecked { get => minivanChecked; set { minivanChecked = value; OnPropertyChanged("MinivanChecked"); } }
        public bool OffroadChecked { get => offroadChecked; set { offroadChecked = value; OnPropertyChanged("OffroadChecked"); } }
        public bool SedanChecked { get => sedanChecked; set { sedanChecked = value; OnPropertyChanged("SedanChecked"); } }

        public string ModelSearch { get => modelSearch; set { modelSearch = value; OnPropertyChanged("ModelSearch"); } }

        public MainPageViewModel() 
        {
            CarItems = new ObservableCollection<CarItemModel> { };
            var rep = new CarRepository();
            CarItems = rep.ShowAll();

            searchCommand = new ChangeCommand(Filter);
            resetCommand = new ChangeCommand(Reset);
        }

        private void Reset()
        {
            CarItems.Clear();
            var list = carRepository.ShowAll();
            foreach (var item in list)
            {
                CarItems.Add(item);
            }

            SliderValue = "50";
            SearchField = "Поиск";
            PowerField = null;

            ComfortChecked = false;
            BusinessChecked = false;
            EcoChecked = false;
            SportChecked = false;


            MinivanChecked = false;
            OffroadChecked = false;
            SedanChecked = false;
            ConvirtibleChecked = false;
        }

        private void Filter()
        {
            CarItems.Clear();
            string body = "";
            string classes = "";

            #region BodyAndClasses
            if (ComfortChecked)
            {
                classes = "Комфорт";
            }
            if (BusinessChecked)
            {
                classes = "Бизнес";
            }
            if (EcoChecked)
            {
                classes = "Эконом";
            }
            if (SportChecked)
            {
                classes = "Спорт";
            }


            if (OffroadChecked)
            {
                body = "Внедорожник";
            }
            if (SedanChecked)
            {
                body = "Седан";
            }
            if (MinivanChecked)
            {
                body = "Минивен";
            }
            if (ConvirtibleChecked)
            {
                body = "Кабриолет";
            }

            #endregion

            Show(carRepository.Filter(PowerField, sliderValue, body, classes, modelSearch));
        }

        private void Show(ObservableCollection<CarItemModel> cars)
        {
            foreach(var car in cars)
            {
                CarItems.Add(car);  
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
