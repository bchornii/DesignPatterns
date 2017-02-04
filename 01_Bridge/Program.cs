using System;

namespace _01_Bridge
{
    public enum WallCreatorType
    {
        Brick,
        Stab
    }
    public static class Config
    {
        public static WallCreatorType WallCreator { get; set; } = WallCreatorType.Brick;
    }

    internal class Program
    {
        private static void Main()
        {
            Config.WallCreator = WallCreatorType.Brick;
            var buildingCompany = new BuildingCompany();

            // збудувати основу
            buildingCompany.BuildingFondation();

            // збудувати стіни з плит
            buildingCompany.BuildingRoom();

            // збудувати стіни з цегли
            buildingCompany.BuildingRoom();
            buildingCompany.BuildingRoom();

            buildingCompany.BuildingRoof();

            Console.ReadLine();
        }
    }
}
