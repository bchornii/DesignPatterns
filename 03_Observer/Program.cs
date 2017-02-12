using System;
using System.Threading;

namespace _03_Observer
{
    internal class Program
    {
        private static void Main()
        {
            var subject = new ClockTimer();
            var observer = new DigitalClock(subject);

            subject.Attach(observer);

            Console.ReadLine();
        }
    }
}
