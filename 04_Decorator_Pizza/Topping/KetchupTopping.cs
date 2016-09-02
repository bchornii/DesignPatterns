namespace _04_Decorator_Pizza
{
    class KetchupTopping : ToppiningDecorator
    {
        public KetchupTopping(BasePizza pizza)
            : base(pizza)
        {
            Price = 0.22;
        }
    }
}
