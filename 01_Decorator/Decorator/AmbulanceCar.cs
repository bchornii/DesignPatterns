using System;

namespace _01_Decorator
{
    public class AmbulanceCar : DecoratorCar
    {
        public AmbulanceCar(Car decoratedCar) 
            : base(decoratedCar)
        {

        }
        public override void Go()
        {
            base.Go();
            Console.WriteLine(".....beep-beep-beep.....");
        }
    }
}
