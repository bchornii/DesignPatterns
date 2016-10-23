using System;

namespace _01_Mediator_brain
{
    internal class Program
    {
        private static void Main()
        {
            var brain = new Brain();
            brain.Ear.HearSomething();

            Console.Read();
        }
    }
}
