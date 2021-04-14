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
        
        [Required(ErrorMessage ="Please Select Total Peoples")]
        public DateTime CheckIn { get; set; }
        
        [Required(ErrorMessage ="Select Date")]
        [DataType(DataType.Date)]
        public DateTime CheckOut { get; set; }
        
        [Required(ErrorMessage ="select Check In")]
        [DataType(DataType.Date)]
        public int TotalPersons { get; set; }

    }
}
