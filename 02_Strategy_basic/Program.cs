using System;

namespace _02_Strategy_sorting
{
    internal class Program
    {
        private static void Main()
        {
            var sort = new SelectionSort();
            var context = new Context
            {
                Strategy = sort
            };
            context.Sort();
            context.PrintArray();

            Console.Read();
        }
    }
}
