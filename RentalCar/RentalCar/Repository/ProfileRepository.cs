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
                var profiles = context.Profiles.Where(profile => profile.Login.Equals(login)).FirstOrDefault();
                if (profiles == null)
                {
                    return 0;
                }
                var profile = profiles.Id;
                return profile;
            }
        }
    }
}
