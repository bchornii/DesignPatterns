using System;

namespace _02_FactoryMethod_ServiceLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = LoggerProvider.GetLogger<LogCustomLogger>();
            logger.LogMessage("hwllo");

            Console.ReadLine();
        }
    }
}
