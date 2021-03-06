﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PizzaProject1.Library;
using PizzaProject1.Context.Data;


namespace PizzaProject1.Context
{
    public class RestaurantRepository : IRestaurantRepository
    {

        private readonly StoreContext _db;
        public RestaurantRepository(StoreContext db)
        {
            _db = db;
        }

        public void AddRestaurant(Library.Restaurant restaurant)
        {
            _db.Restaurant.Add(RestaurantMapper.Map(restaurant));
        }

        public void DeleteRestaurant(int restaurantId)
        {
            _db.Restaurant.Remove(_db.Restaurant.Find(restaurantId));
        }

        public void EditRestaurant(Library.Restaurant restaurant)
        {
            if (_db.Restaurant.Find(restaurant.RestaurantId) != null)
                _db.Restaurant.Update(RestaurantMapper.Map(restaurant));
        }

        //public IEnumerable<Library.Restaurant> GetRestaurantAddressByID(Library.Restaurant restaurant)
        //{
        //    if (_db.Restaurant.Find(restaurant.AddressId) != null)
        //    {
        //        return _db.Address.Where(Address.AddressId == )
        //    }


        //}

        public Library.Restaurant GetRestaurantByRestaurantId(int id)
        {
            var restaurant = _db.Restaurant.Where(x => x.RestaurantId == id).FirstOrDefault();
            return RestaurantMapper.Map(restaurant);
        }

        public IEnumerable<Library.Restaurant> GetRestaurant()
        {
            return _db.Restaurant.Select(x => RestaurantMapper.Map(x));
        }

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
