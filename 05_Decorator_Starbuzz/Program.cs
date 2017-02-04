using System;

namespace _05_Decorator_Starbuzz
{
    internal class Program
    {
        private static void Main()
        {
            var espressoBeverage = new Espresso {Size = CofeeSize.Large};
            Console.WriteLine(espressoBeverage.Description);

            Beverage beverage2 = new HouseBlend {Size = CofeeSize.Small};
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Milk(beverage2);

            Console.WriteLine($"Description : {beverage2.Description}. Cost : {beverage2.Cost()}");            

            Console.Read();
        }
    }
}
