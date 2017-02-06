using System;

namespace _01_ChainOfResponsibility
{
    public static class ConsoleInput
    {
        public static bool TryReadDecimal(string prompt, out decimal value)
        {
            value = default(decimal);

            while (true)
            {
                Console.WriteLine(prompt);
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    return false;
                }

                try
                {
                    value = Convert.ToDecimal(input);
                    return true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The input is not a valid decimal.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The input is not a valid decimal.");
                }
            }
        }
    }
}