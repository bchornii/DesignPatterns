﻿using System;

namespace _01_FactoryMethod
{
    class LogCustomLogger : ILogger
    {
        public void LogError(string message)
        {
            throw new NotImplementedException();
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(string.Format("{0}: {1}", "LogCustom", message));
        }

        public void LogVerboseInformation(string message)
        {
            throw new NotImplementedException();
        }
    }
}
