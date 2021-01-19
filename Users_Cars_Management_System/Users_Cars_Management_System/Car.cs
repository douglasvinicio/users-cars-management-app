using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users_Cars_Management_System
{   
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        
        [Required]
        [MinLength(3)]
        [MaxLength(40)]
        public string MakeModel { get; set; }

        public int OwnerId { get; set; }

    }
}