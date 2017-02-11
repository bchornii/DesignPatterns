using System;

namespace _02_Flyweight_Map
{
    public class MapTreeFlyweight : MapComponent
    {
        public override void Draw(int x, int y)
        {
            Console.WriteLine("{0} Tree at {1}:{2}", Title, x, y);
        }
    }
}
