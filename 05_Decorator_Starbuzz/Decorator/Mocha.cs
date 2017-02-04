using System.Collections.Generic;

namespace _05_Decorator_Starbuzz
{
    public class Mocha : CondimentDecorator
    {
        protected override Dictionary<CofeeSize, double> CoffeSizePrices { get; } = new Dictionary<CofeeSize, double>
        {
            { CofeeSize.Small, -0.05 },
            { CofeeSize.Medium, 0.0 },
            { CofeeSize.Large, 0.05 }
        };
        public Mocha(Beverage beverageItem) : base(beverageItem) {}
        public override string Description => BeverageItem.Description + ", Mocha";
        public override double Cost() => BeverageItem.Cost() + 0.2 + CoffeSizePrices[Size];
    }
}