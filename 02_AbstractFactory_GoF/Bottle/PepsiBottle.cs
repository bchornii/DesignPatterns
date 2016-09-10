using System;

namespace _02_AbstractFactory_GoF
{
    class PepsiBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(this + " interact " + water);
        }
    }
}
