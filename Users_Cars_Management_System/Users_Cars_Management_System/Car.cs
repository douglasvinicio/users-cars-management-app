using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users_Cars_Management_System
{
   public class Car
    {
        //add the columns
        public int CarId { get; set; }

        [Required]
        public string MakeModel { get; set; }
        [Required]
        public int OwnerId { get; set; }

        public Car(int carId, string makeModel, int ownerId)
        {
            this.CarId = carId;
            this.MakeModel = makeModel;
            this.OwnerId = ownerId;
        }
        public Car()
        {
        }
    }
}