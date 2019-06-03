using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject1.Context
{
    public static class PizzaMapper
    {
        public static PizzaProject1.Context.Data.Pizza Map(PizzaProject1.Library.Pizza dmPizza)
        {
            PizzaProject1.Context.Data.Pizza dePizza = new PizzaProject1.Context.Data.Pizza();
            //dePizza.PizzaId = dmPizza.PizzaId;
            dePizza.OrderId = dmPizza.OrderId;
            dePizza.Size = Convert.ToInt32(dmPizza.Size);
            dePizza.Crust = Convert.ToInt32(dmPizza.Crust);
            dePizza.PizzaAmount = dmPizza.PizzaAmount;
            dePizza.Cost = dmPizza.Cost;


            return dePizza;
        }
        public static PizzaProject1.Library.Pizza Map(PizzaProject1.Context.Data.Pizza dePizza) => new PizzaProject1.Library.Pizza
        {
            PizzaId = dePizza.PizzaId,
            OrderId = dePizza.OrderId,
            Size = Convert.ToString(dePizza.Size),
            Crust = Convert.ToString(dePizza.Crust),
            PizzaAmount = dePizza.PizzaAmount,
            Cost = dePizza.Cost,


        };

    }
}
