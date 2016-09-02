using System;

namespace _04_Decorator_Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            //double price = GetTotalPriceForPizza(new Paperoni());
            //Console.WriteLine("Price margherita = {0}",price);
            PizzaOfficiant officiant = new PizzaOfficiant(new MargaritaMega());
            BasePizza pizza = officiant.BuildPizza();
            double price = pizza.GetPrice();
            Console.WriteLine("Price = " + price);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Price = " + GetTotalPriceForPizza(new Margherita()));

            Console.Read();
        }

        static double GetTotalPriceForPizza(BasePizza pizza)
        {
            var extraCheess = new ExtraCheesTopping(pizza);
            var extraKetchup = new KetchupTopping(extraCheess);
            var mushrooms = new MushroomTopping(extraKetchup);
            return mushrooms.GetPrice();
        }
    }
}
