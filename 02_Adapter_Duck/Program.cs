using System;

namespace _02_Adapter_Duck
{
    internal class Program
    {
        private static void Main()
        {
            var duck = new MallartDuck();
            var wildTurkey = new WildTurkey();
            var adapter = new TurkeyAdapter(wildTurkey);

            Console.WriteLine("The turkey says ...");
            wildTurkey.Gobble();
            wildTurkey.Fly();

            Console.WriteLine();
            Console.WriteLine("The duck says ...");
            TestDuck(duck);

            Console.WriteLine();
            Console.WriteLine("Adapter says ...");
            TestDuck(adapter);

            Console.Read();
        }

        private static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
