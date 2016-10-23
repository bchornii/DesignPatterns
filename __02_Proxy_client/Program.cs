using System;

namespace __02_Proxy_client
{
    internal class Program
    {
        private static void Main()
        {
            IActualPrices proxy = new ActualPricesProxy();

            Console.WriteLine("Gold Price: ");
            Console.WriteLine(proxy.GoldPrice);

            Console.WriteLine("Silver Price: ");
            Console.WriteLine(proxy.SilverPrice);

            Console.WriteLine("Dollar to Ruppe Conversion: ");
            Console.WriteLine(proxy.DollarToRupee);

            Console.Read();
        }
    }
}
