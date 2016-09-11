using System;

namespace _02_FactoryMethod_ServiceLocator
{
    class LoggerProvider
    {
        public static ILogger GetLogger<T>() where T : ILogger
        {
            return Activator.CreateInstance<T>();
        }
    }
}
