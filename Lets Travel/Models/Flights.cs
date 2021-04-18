using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_Travel.Models
{
    [Table(name:"Flights")]
    public class Flights
    {
        [Required]
        [Key]
        public int FlightID { get; set; }

        [Required]
        public string FlightName { get; set; }

        [Required]
        public string FlightFrom { get; set; }

        [Required]
        public string FlightTo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string Date { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public string FlightTime { get; set; }

        [Required]
        public int ORDINARYprice { get; set; }

        [Required]
        public int BUSINESSprice { get; set; }

    }
}
