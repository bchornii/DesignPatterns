using System;

namespace _01_Command_Project
{
    internal class Program
    {
        private static void Main()
        {
            var command = new ConcretteCommand(new Receiver());
            var invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            Console.Read();
        }
    }
}
