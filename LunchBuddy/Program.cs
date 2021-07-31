using LunchBuds.LunchBuddies;
using System;
using System.Collections.Generic;

namespace LunchBuds
{
    class Program
    {
        static void Main(string[] args)
        {
            var lindsey = new LunchBuddy("Lindsey", "Satterfield");
            var tad = new LunchBuddy("Tad", "Sekeres");
            var john = new LunchBuddy("John", "Maple");
            lindsey.eat();
            tad.eat("tacos");
            lindsey.eat(new List<LunchBuddy>() { tad, john});
            tad.eat("pizza", new List<LunchBuddy>() { lindsey, john });
        }
    }
}
