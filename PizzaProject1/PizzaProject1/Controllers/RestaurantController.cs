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
            var restaurants = db.GetRestaurant();
            foreach (var restaurant in restaurants)
            {
         
                c = new Models.Restaurant();
                c.RestaurantName = restaurant.RestaurantName;
                c.AddressId = restaurant.AddressId;
                restaurantList.Add(c);
            }

            return View(restaurantList);
        }

        // GET: Restaurant/Details/5
        public ActionResult Details(int id)
        {
            var restaurant = db.GetRestaurantByRestaurantId(id);
            c = new Models.Restaurant();
            c.RestaurantName = restaurant.RestaurantName;
            c.AddressId = restaurant.AddressId;
            restaurantList.Add(c);

            return View(c);
        }

        // GET: Restaurant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Models.Restaurant restaurant)
        {

            PizzaProject1.Library.Restaurant dmc = new Restaurant();
            dmc.RestaurantName = restaurant.RestaurantName;
            dmc.AddressId = restaurant.AddressId;

            try
            {
                // TODO: Add insert logic here
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Restaurant/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

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