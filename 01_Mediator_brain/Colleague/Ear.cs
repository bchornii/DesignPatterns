using System;

namespace _01_Mediator_brain
{
    public class Ear : BodyPart
    {
        public string Sounds { get; private set; } = string.Empty;

        public Ear(Brain brain) : base(brain)
        {
        }

        public void HearSomething()
        {
            Console.WriteLine("Enter what you hear :");
            Sounds = Console.ReadLine();
            Changed();
        }
    }
}
