using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Decorator_Coffe
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffe = new Lime(new Milk(new Espresso()));
            coffe.Make();

            Console.Read();
        }
    }
}
