using System;

namespace _01_FactoryMethod
{
    public class LogCustomLogger : ILogger
    {
        public void LogError(string message)
        {
            throw new NotImplementedException();
        }

        public void LogMessage(string message)
        {
            Console.WriteLine($"LogCustom: {message}");
        }

        public void LogVerboseInformation(string message)
        {
            throw new NotImplementedException();
        }
    }
}
