using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Model
{
    public class ProfileModel
    {

        private string login;
        private string name;
        private string cardNumber;
        private string passport;

        public string Login { get => login; set => login = value; }
        public string Name { get => name; set => name = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public string Passport { get => passport; set => passport = value; }

        public ProfileModel(string login = null, string name = null, string cardNumber = null, string passport = null)
        {
            this.login = login;
            this.name = name;
            this.cardNumber = cardNumber;
            this.passport = passport;
        }
        public ProfileModel() 
        {
            this.login = "";
            this.name = "";
            this.cardNumber = "";
            this.passport = "";
        }

    }
}
