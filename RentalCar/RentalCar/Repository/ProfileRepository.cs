using RentalCar.DataBase;
using RentalCar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Repository
{
    public class ProfileRepository : IProfileRepository
    {
        public int SearchProfileId(string login)
        {
            using (var context = new MyDBContext())
            {
                var profile = context.Profiles.Where(profile => profile.Login.Equals(login)).FirstOrDefault().Id;
                return profile;
            }
        }
    }
}
