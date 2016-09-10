using System;

namespace _02_AbstractFactory_GoF
{
    class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(GetType().Name + " interact with " + water.GetType().Name);
        }
    }
}
