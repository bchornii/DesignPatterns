using System;

namespace _03_FactoryMethod_Abstract
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaType type)
        {
            var pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        // Factory method - defines an interface for object creation but lets
        // subclasses decide which class to instantiate; encapsulates object creation
        public abstract Pizza CreatePizza(PizzaType type);
    }

    public class NyStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Chees: return new NyStyleCheesPizza();

                case PizzaType.Clam:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
                case PizzaType.Peperoni:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }

    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Chees:
                    return new ChicagoStyleCheesPizza();
                case PizzaType.Clam:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
                case PizzaType.Peperoni:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
