namespace _03_Singlton_Lazy_ThreadSafe
{
    class Program
    {
        static void Main(string[] args)
        {
            DoHardWork();
            System.Console.ReadLine();
        }

        static void DoHardWork()
        {
            Logger logger = Logger.Instance;
            HardProcessor process = new HardProcessor(1);
            logger.Log("Hard process created.");
            process.ProcessTo(5);
            logger.Log("Hard process finished.");
        }
    }
}
