using System;
using PizzaProject1;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaProject1.Models.Pizza pizza = new PizzaProject1.Models.Pizza();

            pizza.Size = "3";
            pizza.Crust = "1";
            pizza.PizzaAmount = 2;
            Console.WriteLine($"Size:{pizza.Size} Crust:{pizza.Crust}");
            Console.WriteLine(pizza.PizzaCost());

        }
    }
}
