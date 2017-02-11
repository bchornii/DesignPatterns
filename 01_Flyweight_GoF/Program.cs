using System;

namespace _01_Flyweight_GoF
{
    internal class Program
    {
        private static void Main()
        {
            var initialState = 0;

            Flyweight flyweight = null;
            var factory = new FlyweightFactory();

            flyweight = factory.GetFlyweight("1");
            flyweight.Operation(initialState);

            flyweight = factory.GetFlyweight("10");
            flyweight.Operation(initialState);

            flyweight = new ConcretteFlyweight2();
            flyweight.Operation(initialState);

            Console.ReadLine();
        }
    }
}
