﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaProject1.Library
{
    public interface IRestaurantRepository
    {
        void AddRestaurant(Restaurant restaurant);
        void EditRestaurant(Restaurant restaurant);
        void DeleteRestaurant(int restaurantId);
        //void GetRestaurantAddressById();
        IEnumerable<Restaurant> GetRestaurant();
        Restaurant GetRestaurantByRestaurantId(int id);
        void Save();
    }
}
