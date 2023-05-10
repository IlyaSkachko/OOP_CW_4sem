using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Model
{
    public class UserModel
    {

        private int id;
        private string name;
        private string passport;
        private int cardNumber;

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public string Passport { get { return passport; } }
        public int CardNumber { get { return cardNumber; } }

        public UserModel(int id, string name, string passport, int cardNumber) 
        {
            this.id = id;
            this.name = name;   
            this.passport = passport;
            this.cardNumber = cardNumber;
        }
    }
}
