using System;

namespace _01_FactoryMethod
{
    internal class Program
    {
        private static void Main()
        {
            LoggerProvider provider = LogProviderFactory.GetLoggingProvider<LoggerCustomProvider>();
            provider.Log();

            Console.ReadLine();
        }
    }
}
