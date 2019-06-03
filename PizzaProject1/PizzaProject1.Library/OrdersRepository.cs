using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PizzaProject1.Library;
using PizzaProject1.Context.Data;

namespace PizzaProject1.Context
{
    public class OrdersRepository : IOrdersRepository
    {

        private readonly StoreContext _db;
        public OrdersRepository(StoreContext db)
        {
            _db = db;
        }

        public void AddOrders(Library.Orders Orders)
        {
            _db.Orders.Add(OrdersMapper.Map(Orders));
        }

        public void DeleteOrders(int OrdersId)
        {
            _db.Orders.Remove(_db.Orders.Find(OrdersId));
        }

        public void EditOrders(Library.Orders Orders)
        {
            if (_db.Orders.Find(Orders.OrderId) != null)
                _db.Orders.Update(OrdersMapper.Map(Orders));
        }

        //public Library.Orders GetOrdersByOrdersId(int id)
        //{
        //    var Orders = _db.Orders.Where(x => x.OrderId == id).FirstOrDefault();
        //    return OrdersMapper.Map(Orders);
        //}

        public IEnumerable<Library.Orders> GetOrders()
        {
            return _db.Orders.Select(x => OrdersMapper.Map(x));
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public Library.Orders GetOrdersByOrderId(int id)
        {
            var Orders = _db.Orders.Where(x => x.CustomerId == id).FirstOrDefault();
            return OrdersMapper.Map(Orders);
        }

        public Library.Orders GetOrdersByRestaurantId(int id)
        {
            var rOrders = _db.Orders.Where(x => x.RestaurantId == id).FirstOrDefault();
            return OrdersMapper.Map(rOrders);
        }
    }
}
