namespace _04_Decorator_Pizza
{
    class PizzaOfficiant
    {
        private PizzaBuilder _builder;
        public PizzaOfficiant(PizzaBuilder builder)
        {
            _builder = builder;
        }
        public BasePizza BuildPizza()
        {
            _builder.AddExtraCheese();
            _builder.AddExtraKetchup();
            _builder.AddMushrooms();
            return _builder.GetPizza();
        }
    }
}
