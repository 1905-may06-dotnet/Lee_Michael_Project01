using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaProject1.Library;

namespace PizzaProject1.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantRepository db;

        public RestaurantController(IRestaurantRepository db)
        {
            this.db = db;
        }

        Models.Restaurant c;

        List<Models.Restaurant> restaurantList = new List<Models.Restaurant>();


        // GET: Restaurant
        public ActionResult Index()
        {
            var custID = HttpContext.Session.GetInt32("CustomerId");
            ViewBag.CustID = custID;
            var restID = HttpContext.Session.GetInt32("RestaurantId");
            ViewBag.RestID = restID;
            //ViewBag.ID = Convert.ToInt32(TempData["CustomerId"]);
            var restaurants = db.GetRestaurant();
            foreach (var restaurant in restaurants)
            {
         
                c = new Models.Restaurant();
                c.RestaurantId = restaurant.RestaurantId;
                c.RestaurantName = restaurant.RestaurantName;
                c.AddressId = restaurant.AddressId;
                ////ViewBag.RestID = Convert.ToInt32(TempData["RestaurantId"]);
                ////TempData["RestaurantID"] = c.RestaurantId;
                restaurantList.Add(c);
            }

            return View(restaurantList);
        }

        // GET: Restaurant/Details/5
        public ActionResult Details(int id)
        {
            var restaurant = db.GetRestaurantByRestaurantId(id);
            c = new Models.Restaurant();
            c.RestaurantId = restaurant.RestaurantId;
            c.RestaurantName = restaurant.RestaurantName;
            c.AddressId = restaurant.AddressId;
            HttpContext.Session.SetInt32("RestaurantId", restaurant.RestaurantId);
            restaurantList.Add(c);

            return View(c);
        }

        // GET: Restaurant/Create
        public ActionResult Create()
        {
            //ViewBag.ID = Convert.ToInt32(TempData["CustomerId"]);
            return View();
        }

        // POST: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Models.Restaurant restaurant)
        {

            PizzaProject1.Library.Restaurant dmc = new Restaurant();
            dmc.RestaurantId = restaurant.RestaurantId;
            dmc.RestaurantName = restaurant.RestaurantName;
            dmc.AddressId = restaurant.AddressId;
            HttpContext.Session.SetInt32("RestaurantId", restaurant.RestaurantId);

            try
            {
                // TODO: Add insert logic here
                //ViewBag.ID = Convert.ToInt32(TempData["CustomerId"]);
                //TempData.Keep();
                db.AddRestaurant(dmc);
                db.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // GET: Restaurant/Edit/5
        public ActionResult CreateOrder(PizzaProject1.Library.Restaurant restaurant)
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
            return RedirectToAction("Create", "Orders");
        }

        // POST: Restaurant/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult CreatePizza(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here
        //        ViewBag.RestID = Convert.ToInt32(TempData["RestaurantId"]);
        //        return RedirectToAction("Create", "Pizza");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Restaurant/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Restaurant/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}