using System;
using System.Collections.Generic;

namespace _01_FactoryMethod
{
    public class LogProviderFactory
    {
        private static readonly IDictionary<Type, LoggerProvider> _loggers = new Dictionary<Type, LoggerProvider>
        {
            [typeof(Logger4NetProvider)] = new Logger4NetProvider(),
            [typeof(LoggerCustomProvider)] = new LoggerCustomProvider()
        };

        public static LoggerProvider GetLoggingProvider<T>() where T : LoggerProvider
        {
            return _loggers[typeof(T)];
        }
    }
}
