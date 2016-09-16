namespace _05_Decorator_Starbuzz
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend";
        }
        public override string Description { get; }
        public override double Cost() => .89 + CoffeSizePrices[Size];
    }
}
