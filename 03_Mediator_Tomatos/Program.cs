using System;

namespace _03_Mediator_Tomatos
{
    internal class Program
    {
        private static void Main()
        {
            var mediator = new ConcretteMediator();
            var farmer = new Farmer(mediator);
            var cannery = new Cannery(mediator);
            var shop = new Shop(mediator);

            mediator.Farmer = farmer;
            mediator.Cannery = cannery;
            mediator.Shop = shop;

            farmer.GrowTomato();

            Console.Read();
        }
    }
}
