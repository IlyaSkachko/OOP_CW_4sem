using RentalCar.Commands;
using RentalCar.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RentalCar.ViewModel
{
    public class ModalWindowViewModel : BaseViewModel
    {

        private ICommand orderCommand;

        public ICommand OrderCommand { get { return orderCommand; } }


        private DateTime date = DateTime.Now;
        private int rentalPeriod = 1;
        public DateTime Date { get { return date; } set { date = value; OnPropertyChanged("Date"); } }
        public int RentalPeriod { get { return rentalPeriod; } set { rentalPeriod = value; OnPropertyChanged("RentalPeriod"); } }



        #region CarProperty
        
        public static int CarID { get; set; }

        #endregion

        public ModalWindowViewModel() 
        {
            orderCommand = new RelayCommand(MakeOrder);
        }

        public void MakeOrder()
        {
            if (CheckDate() && rentalPeriod > 0)
            {
                var rentalRepository = new RentalRepository();

                if (rentalRepository.CheckAvailableOrder(AuthorizationViewModel.Login))
                {
                    if (rentalRepository.CheckAvailableCar(CarID, Date, RentalPeriod))
                    {
                        var profRep = new ProfileRepository();
                        rentalRepository.CreateRentalApplication(profRep.SearchProfileId(AuthorizationViewModel.Login), CarID, Date, RentalPeriod);
                        MessageBox.Show("Заказ офомлен!\n Информацию б заказе можно посмотреть в профиле");
                    }
                    else
                    {
                        MessageBox.Show("Этот автомобиль недоступен на данный период");
                    }
                }
                else
                {
                    MessageBox.Show("У вас уже есть заказ");
                }
            }
            else
            {
                MessageBox.Show("Неккоректный ввод данных");
            }
        }

        private bool CheckDate()
        {
            bool isCorrectDate = false;

            if (Date >= DateTime.Now)
            {
                isCorrectDate = true;
            }
            return isCorrectDate;   
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
