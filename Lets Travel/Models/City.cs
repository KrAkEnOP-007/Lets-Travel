using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_Travel.Models
{
    public class City
    {
        [Required]
        [Key]
        public long PinCode { get; set; }
        [Required]
        public string city { get; set; }

    }
}
