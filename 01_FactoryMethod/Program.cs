using System;

namespace _01_FactoryMethod
{
    internal class Program
    {
        private static void Main()
        {
            var logProvider = GetProviderConfig();
            LoggerProvider provider = LoggingProviderFactory.GetLoggingProvider(logProvider);
            provider.Log();

            Console.ReadLine();
        }

        static LoggingProviders GetProviderConfig()
        {
            return LoggingProviders.Log4Net;
        }
    }
}
