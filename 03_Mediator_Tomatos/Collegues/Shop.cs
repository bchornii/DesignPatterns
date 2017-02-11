using System;

namespace _03_Mediator_Tomatos
{
    public class Shop : Collegue
    {
        public Shop(Mediator mediator) : base(mediator)
        {
        }

        public void SellKetchup(string message)
        {
            Console.WriteLine($"{GetType().Name} sold {message}");
        }
    }
}