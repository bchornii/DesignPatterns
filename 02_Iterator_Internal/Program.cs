using System;
using System.Collections;
using System.Collections.Generic;

namespace _02_Iterator_Internal
{
    internal class Program
    {
        private static double Power2(double n)
        {
            return Math.Pow(n, 2);
        }
        private static void Main()
        {
            var userEnumerable = new UserEnumerable();

            IEnumerable power2List = userEnumerable.Transform(Power2);
            foreach (var item in power2List)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 80));
            IEnumerable power3List = userEnumerable.Transform(n => Math.Pow(n, 2));
            foreach (var item in power3List)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }

    public delegate double Function(double arg);
    public class UserEnumerable
    {
        private readonly List<double> _list = new List<double> {1, 2, 3, 4, 5};

        public IEnumerable Transform(Function function)
        {
            foreach (var val in _list)
            {
                yield return function(val);
            }
        }
    }
}
