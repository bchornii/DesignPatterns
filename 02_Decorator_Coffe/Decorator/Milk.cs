using System;

namespace _02_Decorator_Coffe
{
    class Milk : CoffeDecorator
    {
        public Milk(Coffe coffe) 
            : base(coffe)
        {

        }
        public override void Make()
        {
            base.Make();
            Console.WriteLine("Add some milk");
        }
    }
}
