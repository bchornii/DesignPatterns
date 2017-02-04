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
}
