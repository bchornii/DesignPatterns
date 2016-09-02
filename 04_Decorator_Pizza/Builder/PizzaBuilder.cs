namespace _04_Decorator_Pizza
{
    abstract class PizzaBuilder
    {
        protected BasePizza Pizza { get; set; }
        public PizzaBuilder(BasePizza pizza)
        {
            Pizza = pizza;
        }
        public BasePizza GetPizza()
        {
            return Pizza;
        }
        public abstract void AddExtraCheese();
        public abstract void AddExtraKetchup();
        public abstract void AddMushrooms();
    }
}
