using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var proxy = new RobotBombDefuserProxy(41);
                proxy.WalkStraightForward(100);
                proxy.TurnLeft();
                proxy.WalkStraightForward(45);
                proxy.DefuseBomb();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
