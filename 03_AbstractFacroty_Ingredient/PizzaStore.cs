using System;

namespace _03_AbstractFacroty_Ingredient
{
    public abstract class PizzaStore
    {
        public virtual Pizza OrderPizza(PizzaType type)
        {
            var pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            pizza.Pack();
            return pizza;
        }
        protected abstract Pizza CreatePizza(PizzaType type);
    }

    public class NyPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            var pizzaFactory = new NyPizzaIngredientFactory();
            switch (type)
            {
                case PizzaType.Cheese:
                    return new CheesePizza(pizzaFactory) { Name = "New York cheese pizza"};
                case PizzaType.Calm:
                    return new ClamPizza(pizzaFactory) { Name = "New York calm pizza"};
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }        
    }
}
