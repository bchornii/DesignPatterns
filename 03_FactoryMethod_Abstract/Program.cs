using System;

namespace _03_FactoryMethod_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            var nyPizzaStore = new NyStylePizzaStore();
            var chicagoPizzaStore = new ChicagoStylePizzaStore();

            var nyPizza = nyPizzaStore.OrderPizza(PizzaType.Chees);
            Console.WriteLine(new string('-', 80));
            var chicagoPizza = chicagoPizzaStore.OrderPizza(PizzaType.Chees);

            Console.Read();
        }
    }
}
