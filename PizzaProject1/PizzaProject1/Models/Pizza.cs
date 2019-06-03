using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaProject1.Models
{
    public class Pizza
    {

        private string size;
        private string crust;
        private decimal pizzaTotal;
      


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
        public int PizzaAmount { get; set; }

        public int? OrderId { get; set; }
        public int PizzaId { get; set; }
        [DisplayName("Pizza Toppings")]   
        public List<string> PizzaTopping { get; set; }

        public decimal PizzaCost()
        {

            pizzaTotal = 0.00m;

            if (size == "1") pizzaTotal += 7.00M;
            else if (size == "2") pizzaTotal += 10.00M;
            else if (size == "3") pizzaTotal += 12.00M;
            else if (size == "4") pizzaTotal += 15.00M;
            else { }

            if (crust == "1") pizzaTotal += 0.00m;
            else if (crust == "2" || crust == "3") pizzaTotal += 0.50M;
            else if (crust == "4") pizzaTotal += 1.50M;
            else { }

            return pizzaTotal * PizzaAmount;
        }

        //public bool TotalCost()
        //{
        //    if (Cost > 2000 || PizzaAmount > 100)
        //    {
        //        return false;
        //    }
        //    return true;
         
        //}

    }
}

