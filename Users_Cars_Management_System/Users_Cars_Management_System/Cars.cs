using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users_Cars_Management_System
{
    class Cars
    {
        //add the columns
        public int CarId { get; set; }

        public string MakeModel { get; set; }

        public int OwnerId { get; set; }

        public Cars(int carId, string makeModel, int ownerId)
        {
            this.CarId = carId;
            this.MakeModel = makeModel;
            this.OwnerId = ownerId;
        }
        public Cars()
        {
        }
    }
    class CarOwners
    {
        //add the columns
        public int OwnerId { get; set; }

        public string Name { get; set; }

        public int NumOfCars { get; set; }

        public CarOwners()
        {

        }
        public CarOwners(int ownerId, string name, int numOfCars)
        {
            this.OwnerId = ownerId;
            this.Name = name;
            this.NumOfCars = numOfCars;
        }

    }

}
