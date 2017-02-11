using System;
using System.Net.Sockets;
using System.Text;

namespace __02_Proxy_client
{
    public class ActualPricesProxy : IActualPrices
    {
        public string GoldPrice => GetResponseFromServer("g");
        public string SilverPrice => GetResponseFromServer("s");
        public string DollarToRupee => GetResponseFromServer("d");

        private static string GetResponseFromServer(string input)
        {
            var result = string.Empty;
            using (var client = new TcpClient())
            {
                client.Connect("127.0.0.1", 9999);

                var stream = client.GetStream();
                var asen = new ASCIIEncoding();
                var ba = asen.GetBytes(input.ToCharArray());

                stream.Write(ba, 0, ba.Length);

                var br = new byte[100];
                var k = stream.Read(br, 0, br.Length);

                for (var i = 0; i < k; i++)
                {
                    result += Convert.ToChar(br[i]);
                }
                client.Close();
            }
            return result;
        }
    }
}
