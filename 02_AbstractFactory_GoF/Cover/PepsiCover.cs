using System;

namespace _02_AbstractFactory_GoF
{
    class PepsiCover : AbstractCover
    {
        public override void Interact(AbstractBottle bottle)
        {
            Console.WriteLine(this + " interact " + bottle);
        }
    }
}
