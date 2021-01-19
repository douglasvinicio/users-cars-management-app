using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users_Cars_Management_System
{
    public class CarOwner
    {
        //add the columns
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
