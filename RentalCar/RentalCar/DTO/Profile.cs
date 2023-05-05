using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.DTO
{
    public class Profile
    {
        public int Id { get; set; }
        public string Password { get; set; }    
        public string Login { get; set; }
        public int UserID { get; set; }

        public virtual ICollection<RentalApplications> RentalApplications { get; set;}

        public virtual User User { get; set; }
    }
}
