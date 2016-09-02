using System;

namespace _03_Decorator_GoF
{
    class ConcretteDecorator2 : Decorator
    {
        void AddBehaviour()
        {
            Console.WriteLine("Behaviour");
        }
        public override void Operation()
        {
            base.Operation();
            AddBehaviour();
        }
    }
}
