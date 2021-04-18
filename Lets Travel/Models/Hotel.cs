using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_Travel.Models
{
    public class Hotel
    {
        [Required]
        [Key]
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string City { get; set; }
        public long Pincode { get; set; }
        public string HotelAddress { get; set; }
        public string Hotel_Room_Features { get; set; }
        public string Hotel_Additional_Features { get; set; }
        public int Price_Single_Bed { get; set; }
        public int Price_Double_Bed { get; set; }
        public string Pic1 { get; set; }
        public string Pic2 { get; set; }
        public string Pic3 { get; set; }
        public string Pic4 { get; set; }
        public string Pic5 { get; set; }
    }
}
