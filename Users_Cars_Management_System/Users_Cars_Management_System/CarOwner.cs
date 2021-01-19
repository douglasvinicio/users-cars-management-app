using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Users_Cars_Management_System
{
    public class CarOwner
    {
        [Key]
        public int OwnerId { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Name { get; set; }


        public int NumOfCars { get; set; }


        // Constructors

    }
}
