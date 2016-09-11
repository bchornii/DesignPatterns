using System;

namespace _03_Singlton_Lazy_ThreadSafe
{
    public sealed class Logger
    {
        private int _logCount = 0;
        public static Logger Instance => Nested.instance;
        private Logger() { }
        private class Nested
        {
            static Nested() { }
            internal static readonly Logger instance = new Logger();
        }
        public void Log(string message)
        {
            Console.WriteLine(_logCount + " : " + message);
            _logCount++;
        }
    }
}