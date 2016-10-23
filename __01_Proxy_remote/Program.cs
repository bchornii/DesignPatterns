using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace __01_Proxy_remote
{
    internal class Program
    {
        private static void Main()
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var listener = new TcpListener(ip, 9999);

            while (true)
            {
                listener.Start();
                Console.WriteLine("Waiting .....");
                var s = listener.AcceptSocket();

                var b = new byte[100];

                var count = s.Receive(b);

                var input = string.Empty;

                for (var i = 0; i < count; i++)
                {
                    input += Convert.ToChar(b[i]);
                }

                IActualPrices realSubject = new ActualPrices();
                var returnValue = string.Empty;

                switch (input)
                {
                    case "g":
                        returnValue = realSubject.GoldPrice;
                        break;
                    case "s":
                        returnValue = realSubject.SilverPrice;
                        break;
                    case "d":
                        returnValue = realSubject.DollarToRupee;
                        break;
                }

                var asen = new ASCIIEncoding();
                s.Send(asen.GetBytes(returnValue));

                s.Close();
                listener.Stop();
                Console.WriteLine("Response Sent .....");
            }
        }
    }
}
