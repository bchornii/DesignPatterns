using System;

namespace _01_FactoryMethod
{
    class Logger4NetProvider : LoggerProvider
    {
        public override void Log()
        {
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Log4Net provider");
            base.Log();
            Console.WriteLine(new string('-', 80));
        }
        public override ILogger GetLogger()
        {
            return new Log4NetLogger();
        }
    }
}
