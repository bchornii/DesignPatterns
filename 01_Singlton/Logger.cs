using System;

namespace _01_Singlton
{
    sealed class Logger
    {
        private int _logCount = 0;
        private static Logger _loggerInstance = null;
        private Logger() { }
        public static Logger Instance
        {
            get
            {
                if(_loggerInstance == null)
                {
                    _loggerInstance = new Logger();
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
