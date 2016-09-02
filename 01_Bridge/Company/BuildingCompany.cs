using System;

namespace _01_Bridge
{
    class BuildingCompany : IBuildingCompany
    {
        public IWallCreator WallCreator { get; set; }

        public void BuildingFondation()
        {
            Console.WriteLine("Fondation is built.{0}",Environment.NewLine);
        }

        public void BuildingRoof()
        {
            Console.WriteLine("Roof is done.",Environment.NewLine);
        }

        public void BuildingRoom()
        {
            WallCreator.BuildingWallWithDoor();
            WallCreator.BuildingWall();
            WallCreator.BuildingWallWithWindow();
            WallCreator.BuildingWall();
            Console.WriteLine("Room finished.{0}", Environment.NewLine);
        }
    }
}
