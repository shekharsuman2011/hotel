using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelAndLogin.Views.hotel
{
    public class Hotel
    {

        [Key]
        public int id { get; set; }

        [Required]
        public string HotelName { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
