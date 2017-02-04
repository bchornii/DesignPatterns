using System;

namespace _03_Decorator_GoF
{
    internal class Program
    {
        private static void Main()
        {
            Component component = new ConcretteComponent();
            Decorator decorator1 = new ConcretteDecorator1();
            Decorator decorator2 = new ConcretteDecorator2();
            Decorator decorator3 = new ConcretteDecorator2();

            decorator1.Component = component;
            decorator2.Component = decorator1;
            decorator3.Component = decorator2;
            decorator3.Operation();

            Console.Read();
        }
    }
}
