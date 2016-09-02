using System;

namespace _02_Singlton_ThreadSafe
{
    public sealed class Logger
    {
        private int _logCount = 0;
        private static volatile Logger _loggerInstance;
        private static object syncRoot = new object();
        private Logger() { }

        public static Logger Instance
        {
            get
            {
                if (_loggerInstance == null)
                {
                    lock (syncRoot)
                    {
                        _loggerInstance = new Logger();
                    }
                }
                return _loggerInstance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine(_logCount + " : " + message);
            _logCount++;
        }
    }
}
