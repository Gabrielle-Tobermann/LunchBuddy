using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuds.Restaurants
{
    class Restaurant
    {
        // private List<string> Restaurants { get; set; } = new List<string> { "Vui's Kitchen", "Blaze Pizza", "Baja Burrito" };
        public string Name { get; set; }

        public static string randomRestaurant()
        {
            var Restaurants = new List<string> { "Vui's Kitchen", "Blaze Pizza", "Baja Burrito" };
            Random random = new Random();
            var picked = Restaurants[random.Next(Restaurants.Count)];
            return picked;
        }
        public Restaurant()
        {
            Name = randomRestaurant();
        }
    }
}
