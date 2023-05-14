using RentalCar.Commands;
using RentalCar.Model;
using RentalCar.Repository;
using RentalCar.View.AddCar;
using RentalCar.View.MainPage;
using RentalCar.View.Order;
using RentalCar.View.Profile;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RentalCar.ViewModel
{
    public class AdminMainPageViewModel
    {
        #region Commands

        private readonly ICommand searchCommand;
        private readonly ICommand resetCommand;
        private readonly ICommand searchModelCommand;
        private readonly ICommand openAddPage;
        private readonly ICommand openOrderCommand;


        public ICommand OpenOrderCommand { get => openOrderCommand; }
        public ICommand OpenAddPage { get => openAddPage; }
        public ICommand SearchCommand { get => searchCommand; }
        public ICommand ResetCommand { get => resetCommand; }
        public ICommand SearchModelCommand { get => searchModelCommand; }

        private ICommand openMainPageCommand;

        public ICommand OpenMainPageCommand { get => openMainPageCommand; }
        #endregion


        #region Fields

        private CarRepository carRepository = new CarRepository();

        private string sliderValue = "50";
        private string searchField = "";
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



        #endregion


        #region Properties



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

        #endregion



        public AdminMainPageViewModel()
        {
            CarItems = new ObservableCollection<CarItemModel> { };
            var rep = new CarRepository();
            CarItems = rep.ShowAll();

            searchCommand = new ChangeCommand(Filter);
            resetCommand = new ChangeCommand(Reset);
            searchModelCommand = new ChangeCommand(SearchModel);
            openAddPage = new RelayCommand(OpenAdd);
            openMainPageCommand = new RelayCommand(() => { Application.Current.MainWindow.Content = new MainPageAdmin(); });
            openOrderCommand = new RelayCommand(() => { Application.Current.MainWindow.Content = new OrderPage(); });
        }

        private void OpenAdd()
        {
            Application.Current.MainWindow.Content = new CarAddPage();
        }

        private void SearchModel()
        {
            CarItems.Clear();
            var list = carRepository.ModelSearch(SearchField);

            foreach (var item in list)
            {
                CarItems.Add(item);
            }

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
            foreach (var car in cars)
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
