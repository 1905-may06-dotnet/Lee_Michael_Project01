using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaProject1.Library;

namespace PizzaProject1.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrdersRepository db;

        public OrdersController(IOrdersRepository db)
        {
            this.db = db;
        }

        Models.Orders c;

        List<Models.Orders> ordersList = new List<Models.Orders>();

        // GET: Order
        public ActionResult Index()
        {
            var custID = HttpContext.Session.GetInt32("CustomerId");
            ViewBag.CustID = custID;

            var orders = db.GetOrders();
            foreach (var order in orders)
            {
               if(order.CustomerId == custID)
                {

                c = new Models.Orders();
          
                c.OrderId = order.OrderId;
                c.RestaurantId = order.RestaurantId;
                c.CustomerId = order.CustomerId;
                c.TotalCost = order.TotalCost;
                c.OrderDate = order.OrderDate;
                ordersList.Add(c);

                }
            }

            return View(ordersList);
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            var order = db.GetOrdersByOrderId(id);

            c = new Models.Orders();

            c.OrderId = order.OrderId;
            c.RestaurantId = order.RestaurantId;
            c.CustomerId = order.CustomerId;
            c.TotalCost = order.TotalCost;
            c.OrderDate = order.OrderDate;
            ordersList.Add(c);

            return View(c);
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            var custID = HttpContext.Session.GetInt32("CustomerId");
            ViewBag.CustID = custID;
            var OrdersID = HttpContext.Session.GetInt32("OrdersId");
            ViewBag.OrderID = OrdersID;
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Models.Orders order)
        {
            var custID = HttpContext.Session.GetInt32("CustomerId");
            ViewBag.CustID = custID;
            PizzaProject1.Library.Orders dmc = new Orders();
            dmc.CustomerId = custID;
            dmc.OrderId = order.OrderId;
            dmc.RestaurantId = order.RestaurantId;
            dmc.TotalCost = order.TotalCost;
            dmc.OrderDate = order.OrderDate;

            try
            {
                // TODO: Add insert logic here

                //return RedirectToAction(nameof(Index));
                var OrdersID = HttpContext.Session.GetInt32("OrdersId");
                ViewBag.OrderID = OrdersID;
                db.AddOrders(dmc);
                db.Save();
                return RedirectToAction("Index", "Orders");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult CreatePizza(PizzaProject1.Library.Restaurant restaurant)
        {
            //ViewBag.ID = Convert.ToInt32(TempData["CustomerId"]);
            //TempData.Keep();
            //ViewBag.RestID = Convert.ToInt32(TempData["RestaurantId"]);
            //TempData.Keep();
            HttpContext.Session.SetInt32("RestaurantId", restaurant.RestaurantId);
            var restID = HttpContext.Session.GetInt32("RestaurantId");
            ViewBag.RestID = restID;
            var custID = HttpContext.Session.GetInt32("CustomerId");
            ViewBag.CustID = custID;
            return RedirectToAction("Create", "Pizza");
        }

        // POST: Order/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                //return RedirectToAction(nameof(Index));
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                //return RedirectToAction(nameof(Index));
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}