using System.Collections.Generic;

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
