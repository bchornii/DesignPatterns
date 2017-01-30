namespace _03_Singlton_Lazy_ThreadSafe
{
    internal class Program
    {
        private static void Main()
        {
            DoHardWork();
            System.Console.ReadLine();
        }

        private static void DoHardWork()
        {
            var logger = Logger.Instance;
            var process = new HardProcessor(1);
            logger.Log("Hard process created.");
            process.ProcessTo(5);
            logger.Log("Hard process finished.");
        }
    }
}
