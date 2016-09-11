namespace _01_FactoryMethod
{
    public class LoggingProviderFactory
    {
        public static LoggerProvider GetLoggingProvider(LoggingProviders provider)
        {
            switch (provider)
            {
                case LoggingProviders.CustomLog:
                    return new LoggerCustomProvider();
                case LoggingProviders.Log4Net:
                    return new Logger4NetProvider();
                default:
                    return new Logger4NetProvider();
            }
            
        }
    }
}
