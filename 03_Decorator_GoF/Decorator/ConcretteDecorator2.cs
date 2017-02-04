using System;

namespace _03_Decorator_GoF
{
    public class ConcretteDecorator2 : Decorator
    {
        private static void AddBehaviour()
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
