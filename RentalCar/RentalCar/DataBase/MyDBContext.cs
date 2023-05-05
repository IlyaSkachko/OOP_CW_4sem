using RentalCar.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.DataBase
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("RentalCarConnection")
        { }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RentalApplications> RentalApplications { get; set;}
        public DbSet<Car> Cars { get; set; }

    }
}
