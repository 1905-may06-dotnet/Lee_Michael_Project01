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
    }

    public class Pizza
    {

        private string size;
        private string crust;
        private decimal pizzaTotal;
        private int amt = 0;


        [Display(Name = "#")]
        public int Num { get; set; } = 0;

        [Display(Name = "Pizza Toppings")]
        public List<string> PizzaToppings { get; set; }

        [DisplayName("Pizza Size")]
        [Required(ErrorMessage = "Size cannot be blank")]
        public string Size { get { return size; } set { size = value; } }

        [DisplayName("Crust Type")]
        [Required(ErrorMessage = "Crust type cannot be blank")]
        public string Crust { get { return crust; } set { crust = value; } }

        [DisplayName("Cost")]
        public decimal Cost { get { return pizzaTotal; } set { pizzaTotal = value; } }

        [DisplayName("PizzaAmount")]
        public int PizzaAmount { get { return amt; } set { value = amt; } }

        public int? OrderId { get; set; }
        public int PizzaId { get; set; }
        [DisplayName("Pizza Toppings")]   
        public List<string> PizzaTopping { get; set; }

        public decimal PizzaCost()
        {

            pizzaTotal = 0.00m;

            if (Size == "1") pizzaTotal += 7.00M;
            else if (Size == "2") pizzaTotal += 10.00M;
            else if (Size == "3") pizzaTotal += 12.00M;
            else if (Size == "4") pizzaTotal += 15.00M;
            else { }

            if (Crust == "1") pizzaTotal += 0.00m;
            else if (Crust == "2" || Crust == "3") pizzaTotal += 0.50M;
            else if (Crust == "4") pizzaTotal += 1.50M;
            else { }

            return pizzaTotal * PizzaAmount;
        }

    }
}

