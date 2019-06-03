using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaProject1.Models
{
    public class Orders

    {
        [DisplayName("Order Number")]
        public int num { get; set; } = 0;
        [DisplayName("Order ID")]
        public int OrderId { get; set; }
        [DisplayName("Restaurant ID")]
        public int? RestaurantId { get; set; }
        [DisplayName("Customer ID")]
        public int? CustomerId { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime? OrderDate { get; set; }

    }
}
