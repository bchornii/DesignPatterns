using System;

namespace _01_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var monitor = new TemperatureMonitor();
            var reporter = new TemperatureReporter();

            reporter.Subscribe(monitor);
            monitor.GetTemperature();

            Console.Read();
        }
    }
}
