using System;

namespace _01_Singlton
{
    internal class Program
    {
        private static void Main()
        {
            DoHardWork();

            Console.ReadLine();
        }

        static void DoHardWork()
        {
            var logger = Logger.Instance;
            var processor = new HardProcessor(1);
            logger.Log("Hard work started...");
            processor.ProcessTo(5);
            logger.Log("Hard work finished...");
        }
    }
}
