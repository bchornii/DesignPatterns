using System;

namespace _02_Decorator_Coffe
{
    internal class Program
    {
        private static void Main()
        {
            var coffe = new Lime(new Milk(new Espresso()));
            coffe.Make();

            Console.Read();
        }
    }
}
