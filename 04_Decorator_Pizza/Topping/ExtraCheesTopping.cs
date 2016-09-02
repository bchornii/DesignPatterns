namespace _04_Decorator_Pizza
{
    class ExtraCheesTopping : ToppiningDecorator
    {
        public ExtraCheesTopping(BasePizza pizza) 
            : base(pizza)
        {
            Price = 0.99;
        }
    }
}
