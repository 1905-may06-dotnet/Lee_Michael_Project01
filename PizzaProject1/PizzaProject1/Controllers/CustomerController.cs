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
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository db;

        public CustomerController(ICustomerRepository db)
        {
            this.db = db;
        }

        Models.Customer c;

        List<Models.Customer> customerList = new List<Models.Customer>();

        // GET: Customer
        public ActionResult Index()
        {
            //ViewBag.ID = Convert.ToInt32(TempData["CustomerId"]);
            //TempData.Keep();
            var customers = db.GetCustomer();
            foreach (var customer in customers)
            {
                c = new Models.Customer();
                c.Name = customer.GetName(customer.FirstName, customer.LastName);
                c.CustomerId = customer.CustomerId;
                c.Username = customer.Username;
                c.Password = customer.Password;
                customerList.Add(c);
            }

            return View(customerList);

        }

        //public ActionResult LogOut()
        //{
        //    int userId = (int)Session["userID"];
        //    Session.Abandon();
        //    return RedirectToAction("Index", "Login");
        //}

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            var customer = db.GetCustomerByCustomerId(id);
            c = new Models.Customer();
            c.Name = customer.GetName(customer.FirstName, customer.LastName);
            c.CustomerId = customer.CustomerId;
            c.Username = customer.Username;
            c.Password = customer.Password;

            return View(c);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Models.Customer customer)
        {
            PizzaProject1.Library.Customer dmc = new Customer();
            dmc.UserName = customer.Username;
            dmc.Password = customer.Password;
            dmc.FirstName = customer.FirstName;
            dmc.LastName = customer.LastName;

            try
            {
                // TODO: Add insert logic here
                db.AddCustomer(dmc);
                db.Save();
                return RedirectToAction("Login");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return View();
            }
        }
        public ActionResult Login()
        {
            //ViewBag.ID = Convert.ToInt32(TempData["CustomerId"]);
            //TempData["CustomerId"] = ViewBag.ID;
            //TempData.Keep();

            return View();            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(IFormCollection collection, Models.Customer customer)
        {
            //int b = Convert.ToInt32(TempData["a"]);
            //int cd= b;
            PizzaProject1.Library.Customer dmc = new Customer();
            var cust = db.GetCustomer();
            c = new Models.Customer();
            foreach (var x in cust)
            {

                if(x.Username == customer.Username)
                {

                    if(x.Password == customer.Password)
                    {
                        var user = db.GetCustomerByUsername(x.Username);

                        c.CustomerId = x.CustomerId;
              
                        c.Username = x.Username;
                        c.Password = x.Password;

                        //ViewBag.ID = Convert.ToInt32(TempData["CustomerId"]);
                        HttpContext.Session.SetInt32("CustomerId", x.CustomerId);
                        //TempData["CustomerID"] = x.CustomerId;
                        //TempData["Username"] = x.Username;
                        //TempData.Keep();

                        //TempData["C"] = 1;
                        //int ID = Convert.ToInt32(TempData["C"]);
                        //TempData["C"] = ID;

                        //HttpContext.Session.SetInt32("CustomerId", x.CustomerId);
                        //HttpContext.Session.SetString("Username", x.Username);


                        return RedirectToAction("Index", "Restaurant");

                    }
                    else
                    {
                        ViewData["Text"] = "Incorrect Password";
                        return View();
                    }

                }

            }
            return View();
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
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

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
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