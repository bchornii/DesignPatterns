namespace _01_FactoryMethod
{
    public class LoggerCustomProvider : LoggerProvider
    {
        public override ILogger GetLogger()
        {
            return new LogCustomLogger();
        }
    }
}
