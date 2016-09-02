using System;

namespace _02_AbstractFactory_GoF
{
    class CocaColaCover : AbstractCover
    {
        public override void Interact(AbstractBottle bottle)
        {
            Console.WriteLine(this + " interact " + bottle);
        }
    }
}
