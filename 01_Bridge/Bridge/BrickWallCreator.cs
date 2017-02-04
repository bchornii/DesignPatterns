using System;

namespace _01_Bridge
{
    public class BrickWallCreator : IWallCreator
    {
        public void BuildingWall()
        {
            Console.WriteLine("Brick wall.");
        }

        public void BuildingWallWithDoor()
        {
            Console.WriteLine("Brick wall with door.");
        }

        public void BuildingWallWithWindow()
        {
            Console.WriteLine("Brick wall with window.");
        }
    }
}
