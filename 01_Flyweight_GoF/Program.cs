using System;

namespace _01_Flyweight_GoF
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialState = 0;

            Flyweight flyweight = null;
            FlyweightFactory factory = new FlyweightFactory();

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
