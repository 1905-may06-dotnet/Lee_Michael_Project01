using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject1.Library
{
    public interface IOrdersRepository
    {
        void AddOrders(Orders order);
        void EditOrders(Orders order);
        void DeleteOrders(int OrderId);
        IEnumerable<Orders> GetOrders();
        Orders GetOrdersByOrderId(int id);
        Orders GetOrdersByRestaurantId(int id);
        void Save();
    }

}
