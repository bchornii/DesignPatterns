using System;

namespace _03_FactoryMethod_Abstract
{
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
}