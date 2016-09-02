namespace _04_Decorator_Pizza
{
    abstract class ToppiningDecorator : BasePizza
    {
        protected BasePizza Pizza { get; set; }
        public ToppiningDecorator(BasePizza pizza)
        {
            Pizza = pizza;
        }
        public override double GetPrice()
        {
            return Pizza.GetPrice() + base.GetPrice();
        }
    }
}
