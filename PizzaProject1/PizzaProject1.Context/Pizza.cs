using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject1.Library
{
    public class Pizza
    {
        private string size;
        private string crust;
        private decimal pizzaTotal;
        private int amt = 0;

        public int PizzaId { get; set; }
        public int? OrderId { get; set; }
        public string Size { get { return size; } set { size = value; } }
        public string Crust { get {return crust; } set { crust = value; } }
        public decimal cost { get { return pizzaTotal; } set { pizzaTotal = value; } }
        public int PizzaAmount { get { return amt; } set { value = amt; } }
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


            //switch(Size)
            //{
            //    case "1":
            //        pizzaTotal += 7.00m;
            //        break;
            //    case "3":
            //        pizzaTotal += 12.00m;
            //        break;
            //    case "4":
            //        pizzaTotal += 15.00m;
            //        break;
            //    default:
            //        pizzaTotal += 10.00m;
            //        break;

            //}

            //switch(Crust)
            //{
            //    case "2":
            //        pizzaTotal += 0.50m;
            //        break;
            //    case "3":
            //        pizzaTotal += 0.50m;
            //        break;
            //    case "4":
            //        pizzaTotal += 2.00m;
            //        break;
            //    default:
            //        pizzaTotal += 0.00m;
            //        break;
            //}

            return pizzaTotal * PizzaAmount;
        }

        public bool CheckCostAmount()
        {
            if (Cost > 1000.00M) return false; //orders over $1000
            return true;
        }


    }

}
