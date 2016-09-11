using System;

namespace _01_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
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
