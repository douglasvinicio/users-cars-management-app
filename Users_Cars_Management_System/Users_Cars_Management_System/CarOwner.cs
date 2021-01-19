using System;
using System.Linq;
using System.Text;

namespace Users_Cars_Management_System
{
    public class CarOwner
    {
        [Required]
        public int OwnerId { get; set; }

        public string Name { get; set; }

        public int NumOfCars { get; set; }

        public CarOwner()
        {

        }
        public CarOwner(int ownerId, string name, int numOfCars)
        {
            this.OwnerId = ownerId;
            this.Name = name;
            this.NumOfCars = numOfCars;
        }

    }
}
