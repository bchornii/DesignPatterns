using System;

namespace _03_Decorator_GoF
{
    class ConcretteDecorator1 : Decorator
    {
        string addedState = "added state";
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine(addedState);
        }
    }
}
