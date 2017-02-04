using System;

namespace _01_Fasade
{
    internal class Program
    {
        private static void Main()
        {
            var facade = new SkiResortFacade();
            Console.WriteLine($"One day ticket price = {facade.HaveRestWithOwnSkis()}");
            Console.WriteLine($"Rest price = {facade.HaveGoodRest(90, 180, 42, 5, 5)}");

            Console.Read();
        }
    }
}
