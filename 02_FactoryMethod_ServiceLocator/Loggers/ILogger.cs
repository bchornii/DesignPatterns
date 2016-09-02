namespace _02_FactoryMethod_ServiceLocator
{
    public interface ILogger
    {
        void LogMessage(string message);
        void LogError(string message);
        void LogVerboseInformation(string message);
    }
}
