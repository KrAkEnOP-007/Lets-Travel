using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_Travel.Models
{
    public class GetHotels
    {
        [Required(ErrorMessage ="Please Select City")]
        public string City { get; set; }
        
        
        public DateTime? CheckIn { get; set; }
        
       
        public DateTime? CheckOut { get; set; }
        
        public int? TotalPersons { get; set; }

    }
}
