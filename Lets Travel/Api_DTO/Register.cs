using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_Travel.Api_DTO
{
    public class Register
    {
        [Required]
        [Key]
        public int UserNo { get; set; }

        [Required(ErrorMessage = "Enter First Name")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Enter Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter Email Name")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Enter valid email Address")]
        public string Email_Id { get; set; }

        [Required]
        [Display(Name ="User Id")]
        public string User_Id { get; set; }

       
        
        [Required(ErrorMessage = "Enter password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string Mobile_No { get; set; }
    }
}
