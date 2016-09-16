using System;

namespace _05_Decorator_Starbuzz
{
    class Program
    {
        static void Main(string[] args)
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
