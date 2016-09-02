using System;

namespace _01_Bridge
{
    class StabWallCreator : IWallCreator
    {
        public void BuildingWall()
        {
            Console.WriteLine("Stab wall.");
        }

        public void BuildingWallWithDoor()
        {
            Console.WriteLine("Stab wall with door.");
        }

        public void BuildingWallWithWindow()
        {
            Console.WriteLine("Stab wall with window.");
        }
    }
}
