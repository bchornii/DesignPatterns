using System.Collections.Generic;

namespace _05_Decorator_Starbuzz
{
    public abstract class Beverage
    {
        public CofeeSize Size { get; set; }
        protected virtual Dictionary<CofeeSize, double> CoffeSizePrices { get; } = new Dictionary<CofeeSize, double>
        {
            {CofeeSize.Small, -0.4},
            {CofeeSize.Medium, 0.0},
            {CofeeSize.Large, 0.4}
        };
        public virtual string Description { get; } = "unknown beverage";        
        public abstract double Cost();
    }
}
