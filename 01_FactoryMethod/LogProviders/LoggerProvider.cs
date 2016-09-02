namespace _01_FactoryMethod
{
    abstract class LoggerProvider
    {
        ILogger logger;
        public LoggerProvider()
        {
            logger = GetLogger();            
        }
        public void Log()
        {
            logger.LogMessage("hello from provider");
        }

        public abstract ILogger GetLogger();
    }  
}
