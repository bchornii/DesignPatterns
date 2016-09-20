using System;

namespace _03_AbstractFacroty_Ingredient
{
    class Program
    {
        private static void Main(string[] args)
        {
            var nyPizzaStore = new NyPizzaStore();
            nyPizzaStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine(new string('-', 80));
            nyPizzaStore.OrderPizza(PizzaType.Calm);
            Console.Read();
        }
    }
}
