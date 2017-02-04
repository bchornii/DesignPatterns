using System.Collections.Generic;

namespace _05_Decorator_Starbuzz
{
    public class Milk : CondimentDecorator
    {
        protected override Dictionary<CofeeSize, double> CoffeSizePrices { get; } = new Dictionary<CofeeSize, double>
        {
            { CofeeSize.Small, -0.01 },
            { CofeeSize.Medium, 0.0 },
            { CofeeSize.Large, 0.01 }
        };
        public Milk(Beverage beverageItem) : base(beverageItem) {}
        public override double Cost() => BeverageItem.Cost() + 0.8 + CoffeSizePrices[Size];        
        public override string Description => BeverageItem.Description + ", Milk";
    }
}