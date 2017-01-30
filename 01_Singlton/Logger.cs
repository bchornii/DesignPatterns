using System;

namespace _01_Singlton
{
    public sealed class Logger
    {
        private int _logCount = 0;
        private static Logger _loggerInstance = null;
        private Logger() { }
        public static Logger Instance => _loggerInstance ?? (_loggerInstance = new Logger());

        public void Log(string message)
        {
            Console.WriteLine(_logCount + " : " + message);
            _logCount++;
        }
    }
}
