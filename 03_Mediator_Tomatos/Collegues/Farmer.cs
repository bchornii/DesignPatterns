using System;

namespace _03_Mediator_Tomatos
{
    public class Farmer : Collegue
    {
        public Farmer(Mediator mediator) 
            : base(mediator)
        {
        }

        public void GrowTomato()
        {
            Console.WriteLine($"{GetType().Name} raised tomato");
            Mediator.Send("tomato", this);
        }
    }
}