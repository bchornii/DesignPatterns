using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IToyFactory factory = new WoodenToysFactory();
            Cat cat = factory.GetCat();
            Bear bear = factory.GetBear();

            Console.WriteLine("Cat name : {0}, Bear name : {1}", cat.Name, bear.Name);
            Console.ReadLine();
        }
    }
}
