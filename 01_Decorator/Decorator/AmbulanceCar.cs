using System;

namespace _01_Decorator
{
    class AmbulanceCar : DecoratorCar
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
