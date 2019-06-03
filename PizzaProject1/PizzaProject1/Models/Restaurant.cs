using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaProject1.Models
{
    public class Restaurant
    {
        //[DisplayName("#")]
        //public int Num { get; set; } = 0;
        [DisplayName("Location Name")]
        [Required(ErrorMessage = "Restaurant Name required")]
        public string RestaurantName { get; set; }
        [DisplayName("Address")]
        public int AddressId { get; set; }
        [DisplayName("Restraunt ID")]
        public int RestaurantId { get; set; }
    }
}
