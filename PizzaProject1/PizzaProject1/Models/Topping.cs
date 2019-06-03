using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaProject1.Models
{
    public class Topping
    {
        [DisplayName("#")]
        public int Num { get; set; } = 0;

        [DisplayName("Topping Name")]
        public string ToppingName { get; set; }

        [DisplayName("Amount of topping")]
        public int? Count { get; set; }

        public int ToppingId { get; set; }
    }
}
