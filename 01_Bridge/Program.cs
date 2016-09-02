using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var brickWallCreator = new BrickWallCreator();
            var stabWallCreator = new StabWallCreator();

            var buildingCompany = new BuildingCompany();

            // збудувати основу
            buildingCompany.BuildingFondation();

            // збудувати стіни з плит
            buildingCompany.WallCreator = brickWallCreator;
            buildingCompany.BuildingRoom();

            // збудувати стіни з цегли
            buildingCompany.WallCreator = stabWallCreator;
            buildingCompany.BuildingRoom();
            buildingCompany.BuildingRoom();

            buildingCompany.BuildingRoof();

            Console.ReadLine();
        }
    }
}
