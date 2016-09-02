using System;

namespace _01_Singlton
{
    class Program
    {
        static void Main(string[] args)
        {
            DoHardWork();

            Console.ReadLine();
        }

        static void DoHardWork()
        {
            Logger logger = Logger.Instance;
            HardProcessor processor = new HardProcessor(1);
            logger.Log("Hard work started...");
            processor.ProcessTo(5);
            logger.Log("Hard work finished...");
        }
    }
}
