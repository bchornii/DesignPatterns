using System;

namespace _03_Decorator_GoF
{
    class ConcretteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Concrette component");
        }
    }
}
