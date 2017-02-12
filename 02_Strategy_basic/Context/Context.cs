using System;

namespace _02_Strategy_sorting
{
    public class Context
    {
        public Strategy Strategy { get; set; }
        private readonly int[] _array = {3, 5, 1, 2, 4};

        public void Sort()
        {
            Strategy.Sort(_array);
        }

        public void PrintArray()
        {
            for (var i = 0; i < _array.Length; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}