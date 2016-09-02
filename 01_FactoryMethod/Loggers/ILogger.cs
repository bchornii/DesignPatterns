namespace _01_FactoryMethod
{
    public interface ILogger
    {
        void LogMessage(string message);
        void LogError(string message);
        void LogVerboseInformation(string message);
    }
}
