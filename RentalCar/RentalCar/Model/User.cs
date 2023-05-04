using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Model
{
    public class User
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Passport { get; set; }
        public string CardNumber { get; set; }
    }
}
