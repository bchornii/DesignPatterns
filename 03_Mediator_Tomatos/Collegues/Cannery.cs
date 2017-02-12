using System;

namespace _03_Mediator_Tomatos
{
    public class Cannery : Collegue
    {
        public Cannery(Mediator mediator) : base(mediator)
        {
        }

        public void MakeKetchup(string message)
        {
            Console.WriteLine($"{GetType().Name} produced {message} ketchup");
            Mediator.Send($"{message} ketchup", this);
        }
    }
}