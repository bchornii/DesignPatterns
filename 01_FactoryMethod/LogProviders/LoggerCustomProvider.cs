namespace _01_FactoryMethod
{
    class LoggerCustomProvider : LoggerProvider
    {
        public override ILogger GetLogger()
        {
            return new LogCustomLogger();
        }
    }
}
