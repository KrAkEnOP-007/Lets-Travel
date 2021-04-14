using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_Travel.Models
{
    public class SignUp
    {
        [Required(ErrorMessage ="Enter First Name")]
        [Display(Name ="First Name")]
        public String FirstName { get; set; }
        [Required(ErrorMessage = "Enter Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Enter Email Name")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage ="Enter valid email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter password")]
        [Display(Name = "Password")]
        [Compare("ConfirmPassword", ErrorMessage ="Passwords Does not match")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please Confirm Password")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
