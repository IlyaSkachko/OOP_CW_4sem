using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Model
{
    public class RentalApplicationModel
    {

        private int id;
        private int profileID;
        private int carID;
        private DateTime dateRentalCar;
        private int rentalPeriod;

        public int Id { get { return id; }  }
        public int ProfileID { get {  return profileID; } }
        public int CarID { get { return carID; } }
        public DateTime DateRentalCar { get { return dateRentalCar; } }
        public int RentalPeriod { get {  return rentalPeriod; } }


        public RentalApplicationModel(int id, int profileID, int carID, DateTime dateRentalCar, int rentalPeriod)
        {
            this.id = id;
            this.profileID = profileID;
            this.carID = carID;
            this.dateRentalCar = dateRentalCar;
            this.rentalPeriod = rentalPeriod;
        }



    }
}
