using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_Travel.Models
{
    public class GetFlights
    {
        [Required(ErrorMessage ="Please Select A place")]
        [Display(Name ="Flight From")]
        public string FlightFrom { get; set; }
        [Required(ErrorMessage = "Please Select A place")]
        [Display(Name = "Flight To")]
        public string FlightTo { get; set; }
        [Required(ErrorMessage = "Please Select A Date")]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public string OnDate { get; set; }

    }
}
