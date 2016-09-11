using System;

namespace _01_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var tripBuilder = new TripLaptopBuilder();
            var gamerBuilder = new GamingLaptopBuilder();
            var buyer = new LaptopBuyer();
            buyer.SetLaptopBuilder(tripBuilder);
            Laptop laptop = buyer.ConstructLaptop();

            Console.WriteLine(laptop.ToString());
            Console.Read();
        }
    }
}
