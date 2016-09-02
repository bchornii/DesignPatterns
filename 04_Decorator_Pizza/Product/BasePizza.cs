namespace _04_Decorator_Pizza
{
    abstract class BasePizza
    {
        protected double Price { private get; set; }
        public virtual double GetPrice()
        {
            return Price;
        }
    }
}
