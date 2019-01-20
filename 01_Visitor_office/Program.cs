using System;
using _01_Visitor_office.Elements;
using _01_Visitor_office.Visitor;

namespace _01_Visitor_office
{
    internal class Program
    {
        private static void Main()
        {
            var floor1 = new Floor(1);
            floor1.AddRoom(new Room(100));
            floor1.AddRoom(new Room(102));
            floor1.AddRoom(new Room(104));

            var floor2 = new Floor(2);
            floor2.AddRoom(new Room(200));
            floor2.AddRoom(new Room(202));
            floor2.AddRoom(new Room(204));

            var office = new OfficeBuilding
            {
                BuildingName = "[Dessign pattern center]",
                ElectricitySystemId = 900
            };
            office.AddFloor(floor1);
            office.AddFloor(floor2);

            var electrician = new ElectricitySystemVisitor();
            office.Accept(electrician);

            Console.Read();
        }
    }
}
