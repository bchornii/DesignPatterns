using System;

namespace _01_Decorator
{
    public class TurboCar : DecoratorCar
    {
        public TurboCar(Car decoratedCar) 
            : base(decoratedCar)
        {
        }

        public override void Go()
        {
            base.Go();
            Console.WriteLine(".....Euuuuuuuuu......");
        }
    }
}
