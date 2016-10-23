using System;

namespace _01_Mediator_brain
{
    public class Face : BodyPart
    {
        public Face(Brain brain) : base(brain)
        {

        }

        public void Smile()
        {
            Console.WriteLine("Face : smiling");
        }
    }
}
