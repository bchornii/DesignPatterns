using System;

namespace _01_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerProvider provider = new LoggerCustomProvider();
            provider.Log();

            Console.ReadLine();
        }
    }
}
