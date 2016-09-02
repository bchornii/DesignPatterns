using System;
using System.Collections.Generic;

namespace _01_ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var capuccino1 = new Food { Name = "Capuccino", Ingridients = new List<string> { "Coffe", "Milr", "Sugar" } };
            var capuccino2 = new Food { Name = "Capuccino", Ingridients = new List<string> { "Coffe", "Milr" } };

            var soup1 = new Food { Name = "Soap with meat", Ingridients = new List<string> { "Meat", "Water" } };
            var meat = new Food { Name = "Meat", Ingridients = new List<string> { "Meat" } };

            var girlFriend = new GirlFriend(null);
            var bestFriend = new BestFriend(girlFriend);

            bestFriend.HandleFood(capuccino1);
            bestFriend.HandleFood(meat);
            bestFriend.HandleFood(capuccino2);
            bestFriend.HandleFood(soup1);

            Console.ReadLine();
        }
    }
}
