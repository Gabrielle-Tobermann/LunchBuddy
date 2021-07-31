using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchBuds.Restaurants;

namespace LunchBuds.LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Rest { get; set; }

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Rest = Restaurant.randomRestaurant();
        }

        public string eat()
        {
            Console.WriteLine($"{FirstName} is eating at {Rest}");
            return Rest;
        }

        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office.");
        }

        public void eat(List<LunchBuddy> companions)
        {
            Console.WriteLine($"{FirstName} {LastName} is at {Rest} with...");
            foreach (var companion in companions)
            {
                Console.WriteLine(companion.FirstName);
            }
        }

        public void eat(string food, List<LunchBuddy> companions)
        {

            Console.WriteLine($"{FirstName} {LastName} is eating at {Rest}. {FirstName}" +
                $" ordered {food} with...");
            foreach(var companion in companions)
            {
                Console.WriteLine(companion.FirstName);
            }
        }
    }
}
