namespace _01_FactoryMethod
{
    public abstract class LoggerProvider
    {
        public virtual void Log()
        {
            GetLogger().LogMessage("hello from provider");
        }

        public abstract ILogger GetLogger();
    }  
}
