using System;

namespace _01_Mediator_brain
{
    internal class Program
    {
        private static void Main()
        {
            var brain = new Brain();
            var ear = new Ear(brain);
            var face = new Face(brain);

            ear.HearSomething();

            Console.Read();
        }
    }
}
