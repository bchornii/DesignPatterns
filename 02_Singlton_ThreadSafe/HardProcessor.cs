namespace _02_Singlton_ThreadSafe
{
    class HardProcessor
    {
        private int _start;
        public HardProcessor(int start)
        {
            _start = start;
            Logger.Instance.Log("Processor just created");
        }

        public int ProcessTo(int end)
        {
            int sum = 0;
            for (int i = 0; i < end; i++)
            {
                sum += i;
            }
            Logger.Instance.Log("Processor just calculated some value : " + sum);
            return sum;
        }
    }
}
