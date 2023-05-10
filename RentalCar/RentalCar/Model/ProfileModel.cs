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

        private int id;
        private string login;
        private string password;
        private int userId;
        public int Id { get {return id; } }
        public string Password { get { return password; } }
        public string Login { get { return login; } }
        public int UserID { get { return userId; } }


        public ProfileModel(int id, string password, string login, int userID)
        {
            this.id = id;
            this.password = password;
            this.login = login;
            this.userId = userID;
        }
    }
}
