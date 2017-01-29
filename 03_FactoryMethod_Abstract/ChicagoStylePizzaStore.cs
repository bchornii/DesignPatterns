using System;

namespace _03_FactoryMethod_Abstract
{
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