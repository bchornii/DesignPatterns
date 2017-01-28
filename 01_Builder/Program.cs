using System;

namespace _01_Builder
{
    internal class Program
    {
        private static void Main()
        {
            var builder = new TripLaptopBuilder();
            //var builder = new GamingLaptopBuilder();
            var buyer = new LaptopBuyer(builder);            
            buyer.ConstructLaptop();
            var laptop = builder.GetLaptop();

            Console.WriteLine(laptop.ToString());
            Console.Read();
        }
    }
}
