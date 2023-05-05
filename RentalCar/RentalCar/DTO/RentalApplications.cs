using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.DTO
{
    public class RentalApplications
    {
        public int Id { get; set; }
        public int ProfileID { get; set; } 
        public int CarID { get; set; }
        public DateTime DateRentalCar { get; set; }
        public int RentalPeriod { get; set; }

        public virtual Profile Profile { get; set; }    
        public virtual Car Car { get; set; }
    }
}
