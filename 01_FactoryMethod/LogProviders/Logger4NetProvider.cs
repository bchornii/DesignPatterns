namespace _01_FactoryMethod
{
    class Logger4NetProvider : LoggerProvider
    {
        public override ILogger GetLogger()
        {
            return new Log4NetLogger();
        }
    }
}
