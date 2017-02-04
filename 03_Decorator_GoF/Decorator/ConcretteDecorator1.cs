using System;

namespace _03_Decorator_GoF
{
    public class ConcretteDecorator1 : Decorator
    {
        private readonly string _addedState = "added state";
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine(_addedState);
        }
    }
}
