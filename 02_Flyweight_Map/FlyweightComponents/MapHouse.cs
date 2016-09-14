using System;

namespace _02_Flyweight_Map
{
    public class MapHouse : MapComponent
    {
        public override void Draw(int x, int y)
        {
            Console.WriteLine("{0} House at {1}:{2}", Title, x, y);
        }
    }
}
