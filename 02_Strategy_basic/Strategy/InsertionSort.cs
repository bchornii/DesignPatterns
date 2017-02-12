using System;

namespace _02_Strategy_sorting
{
    // Сортировка вставками.
    public class InsertionSort : Strategy
    {
        public override void Sort(int[] array)
        {
            Console.WriteLine("InsertionSort");
            for (var i = 1; i < array.Length; i++)
            {
                var j = 0;
                var buffer = array[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (array[j] < buffer)
                        break;
                    array[j + 1] = array[j];
                }
                array[j + 1] = buffer;
            }
        }
    }
}