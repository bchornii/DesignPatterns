namespace _05_Decorator_Starbuzz
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage BeverageItem { get; }       

        protected CondimentDecorator(Beverage beverageItem)
        {
            BeverageItem = beverageItem;
        }        
    }
}
