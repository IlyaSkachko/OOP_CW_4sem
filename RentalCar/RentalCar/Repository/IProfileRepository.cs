using RentalCar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Repository
{
    public interface IProfileRepository
    {
        int SearchProfileId(string login);
    }
}
