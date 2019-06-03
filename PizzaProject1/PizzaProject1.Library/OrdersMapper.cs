using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject1.Context
{
    public static class OrdersMapper
    {
        public static PizzaProject1.Context.Data.Orders Map(PizzaProject1.Library.Orders dmOrders)
        {
            PizzaProject1.Context.Data.Orders deOrders = new PizzaProject1.Context.Data.Orders();
            deOrders.OrderId = dmOrders.OrderId;
            deOrders.RestaurantId = dmOrders.RestaurantId;
            deOrders.CustomerId = dmOrders.CustomerId;
            deOrders.TotalCost = dmOrders.TotalCost;
            deOrders.OrderDate = dmOrders.OrderDate;

            return deOrders;
        }
        public static PizzaProject1.Library.Orders Map(PizzaProject1.Context.Data.Orders deOrders) => new PizzaProject1.Library.Orders
        {
            OrderId = deOrders.OrderId,
            RestaurantId = deOrders.RestaurantId,
            CustomerId = deOrders.CustomerId,
            TotalCost = deOrders.TotalCost,
            OrderDate = deOrders.OrderDate,
            
        };

    }
}
