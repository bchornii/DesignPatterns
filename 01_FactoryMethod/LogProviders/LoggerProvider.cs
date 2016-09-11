namespace _01_FactoryMethod
{
    public abstract class LoggerProvider
    {
        ILogger logger;
        public LoggerProvider()
        {
            logger = GetLogger();            
        }
        public virtual void Log()
        {
            logger.LogMessage("hello from provider");
        }

        public abstract ILogger GetLogger();
    }  
}
