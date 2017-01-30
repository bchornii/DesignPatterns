namespace _03_Singlton_Lazy_ThreadSafe
{
    public class HardProcessor
    {
        private int _start;
        public HardProcessor(int start)
        {
            _start = start;
            Logger.Instance.Log("Processor just created");
        }

        public int ProcessTo(int end)
        {
            var sum = 0;
            for (var i = 0; i < end; i++)
            {
                sum += i;
            }
            Logger.Instance.Log("Processor just calculated some value : " + sum);
            return sum;
        }
    }
}
