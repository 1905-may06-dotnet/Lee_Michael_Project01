using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaProject1.Library;

namespace PizzaProject1.Controllers
{
    public class PizzaController : Controller
    {

        private readonly IPizzaRepository db;

        public PizzaController(IPizzaRepository db)
        {
            this.db = db;
        }

        Models.Pizza p;

        List<Models.Pizza> pizzaList = new List<Models.Pizza>();

        // GET: Pizza
        public ActionResult PizzaIndex()
        {
            var OrdersID = HttpContext.Session.GetInt32("OrdersId");
            ViewBag.OrderID = OrdersID;
            var custID = HttpContext.Session.GetInt32("CustomerId");
            ViewBag.CustID = custID;
            var pizzas = db.GetPizza();
            foreach (var pizza in pizzas)
            {
                p = new Models.Pizza();
                p.PizzaToppings = pizza.PizzaTopping;
                p.Size = pizza.Size;
                p.Crust = pizza.Crust;
                p.Cost = pizza.Cost;

                pizzaList.Add(p);
            }

            return View(pizzaList);
        }

        // GET: Pizza/Details/5
        public ActionResult PizzaDetails(int id)
        {
            var OrdersID = HttpContext.Session.GetInt32("OrdersId");
            ViewBag.OrderID = OrdersID;
            var pizza = db.GetPizzaByPizzaId(id);
            p = new Models.Pizza();
            p.PizzaToppings = pizza.PizzaTopping;
            p.Size = pizza.Size;
            p.Crust = pizza.Crust;
            p.Cost = pizza.Cost;

            return View(p);
        }

        // GET: Pizza/Create
        public ActionResult Create()
        {
            var custID = HttpContext.Session.GetInt32("CustomerId");
            ViewBag.CustID = custID;
            var OrdersID = HttpContext.Session.GetInt32("OrdersId");
            ViewBag.OrderID = OrdersID;
            return View();
        }

        // POST: Pizza/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Models.Pizza pizza)
        {

            var custID = HttpContext.Session.GetInt32("CustomerId");
            ViewBag.CustID = custID;

            if (custID == null)
            {
                ViewData["text"] = "Please Log In to place your order.";
                return View();
            }

            PizzaProject1.Library.Pizza dmc = new Pizza();
            dmc.PizzaId = pizza.PizzaId;
            HttpContext.Session.SetInt32("PizzaId", pizza.PizzaId);
            dmc.Size = pizza.Size;
            dmc.Crust = pizza.Crust;
            dmc.PizzaAmount = 2; //pizza.PizzaAmount;
            dmc.OrderId = pizza.OrderId;
            dmc.Cost = pizza.PizzaCost();

            try
            {
                // TODO: Add insert logic here

                var PizzaID = HttpContext.Session.GetInt32("PizzaId");
                ViewBag.PizzaID = PizzaID;
                db.AddPizza(dmc);
                db.Save();
                return RedirectToAction("Index", "Topping");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pizza/Edit/5
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

        // GET: Pizza/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pizza/Delete/5
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