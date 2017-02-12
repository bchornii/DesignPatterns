using System;

namespace _02_Strategy_sorting
{
    // Пузырьковая сортировка.
    public class BubbleSort : Strategy
    {
        public override void Sort(int[] array)
        {
            Console.WriteLine("BubbleSort");
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = array.Length - 1; j > i; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        var temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }
    }
}