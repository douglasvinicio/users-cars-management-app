using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users_Cars_Management_System
{
    class UsersCarsDbContext : DbContext
    {
       public DbSet<Car> Cars { get; set; }
       public DbSet<CarOwner> CarOwners { get; set; }
    }
}
