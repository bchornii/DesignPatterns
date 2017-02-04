namespace _02_Singlton_ThreadSafe
{
    internal class Program
    {
        private static void Main()
        {
            DoHardWork();
            System.Console.ReadLine();
        }

        static void DoHardWork()
        {
            var logger = Logger.Instance;
            var process = new HardProcessor(1);
            logger.Log("Hard process created.");
            process.ProcessTo(5);
            logger.Log("Hard process finished.");
        }
    }
}
