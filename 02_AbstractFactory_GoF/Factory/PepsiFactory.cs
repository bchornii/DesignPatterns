using System;

namespace _02_AbstractFactory_GoF
{
    class PepsiFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new PepsiCover();
        }

        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }
    }
}
