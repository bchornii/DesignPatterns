using System;

namespace _01_Mediator_brain
{
    public class Brain
    {
        public Ear Ear { get; private set; }
        public Face Face { get; private set; }
        public Brain()
        {
            Ear = new Ear(this);
            Face = new Face(this);
        }

        public void SomethingHappendToBodyPart(BodyPart bodyPart)
        {
            if (bodyPart is Ear)
            {
                string sound = ((Ear) bodyPart).Sounds;
                if (sound.Contains("stupid"))
                {
                    Console.WriteLine("Attack");
                }
                if (sound.Contains("cool"))
                {
                    Face.Smile();
                }
            }
        }
    }
}
