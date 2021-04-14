using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_Travel.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Please enter An Email Address")]
        [Display(Name ="Email Address")]
        [EmailAddress(ErrorMessage ="Please Enter va valid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please Enter password")]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
