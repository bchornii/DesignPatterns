using System;

namespace _01_State_Gummball
{
    internal class Program
    {
        private static void Main()
        {
            var machine = new GumballMachine(5);
            machine.InsertQuarter();
            machine.TurnCrank();

            Console.Read();
        }
    }
}
