using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaProject1.Library;

namespace PizzaProject1.Controllers
{
    public class ToppingController : Controller
    {
        private readonly IToppingRepository db;

        public ToppingController(IToppingRepository db)
        {
            this.db = db;
        }

        Models.Topping t;

        List<Models.Topping> toppingList = new List<Models.Topping>();

        // GET: Toppings
        public ActionResult Index()
        {
            var toppings = db.GetTopping();
            foreach (var topping in toppings)
            {
                t = new Models.Topping();
                t.ToppingName = topping.ToppingName;
                t.Count = topping.Count;

                toppingList.Add(t);
            }

            return View(toppingList);
        }

        // GET: Topping/Details/5
        public ActionResult Details(int id)
        {
            var topping = db.GetToppingByToppingId(id);
            t = new Models.Topping();
            t.ToppingName = topping.ToppingName;
            t.Count = topping.Count;

            toppingList.Add(t);

            return View(t);
        }

        // GET: Topping/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Topping/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Models.Topping topping)
        {
            try
            {
                // TODO: Add insert logic here
                PizzaProject1.Library.Topping dmc = new Topping();
                dmc.ToppingId = topping.ToppingId;
                dmc.ToppingName = topping.ToppingName;

                //return RedirectToAction(nameof(Index));
                return View();
            }
            catch
            {
                return View();
            }
        }

        //// POST: Pizza/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection, Models.Pizza pizza)
        //{

        //    var custID = HttpContext.Session.GetInt32("CustomerId");
        //    ViewBag.CustID = custID;

        //    if (custID == null)
        //    {
        //        ViewData["text"] = "Please Log In to place your order.";
        //        return View();
        //    }

        //    PizzaProject1.Library.Pizza dmc = new Pizza();
        //    dmc.PizzaId = pizza.PizzaId;
        //    HttpContext.Session.SetInt32("PizzaId", pizza.PizzaId);
        //    dmc.Size = pizza.Size;
        //    dmc.Crust = pizza.Crust;
        //    dmc.PizzaAmount = 2; //pizza.PizzaAmount;
        //    dmc.OrderId = pizza.OrderId;
        //    dmc.Cost = pizza.PizzaCost();

        //    try
        //    {
        //        // TODO: Add insert logic here

        //        var PizzaID = HttpContext.Session.GetInt32("PizzaId");
        //        ViewBag.PizzaID = PizzaID;
        //        db.AddPizza(dmc);
        //        db.Save();
        //        return RedirectToAction("Create", "Topping");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Topping/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Topping/Edit/5
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

        // GET: Topping/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Topping/Delete/5
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