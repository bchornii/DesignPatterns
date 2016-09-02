namespace _04_Decorator_Pizza
{
    class MushroomTopping : ToppiningDecorator
    {
        public MushroomTopping(BasePizza pizza) 
            : base(pizza)
        {
            Price = 1.22;
        }
    }
}
