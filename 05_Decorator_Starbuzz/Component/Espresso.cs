namespace _05_Decorator_Starbuzz
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }
        public override string Description { get; }
        public override double Cost() => 1.99 + CoffeSizePrices[Size];
    }
}
