using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.DTO
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string CarBody { get; set; }
        public int Power { get; set; }
        public string Color { get; set; }
        public string Class { get; set; }
        public int Capacity { get; set; }
        public float FuelConsumption { get; set; }
        public int Price { get; set; }
        public string Photo { get; set; }

        public virtual ICollection<RentalApplications> RentalApplications { get; set; }
    }
}
