using System;
using _01_Visitor_office.Elements;

namespace _01_Visitor_office.Visitor
{
    public class ElectricitySystemVisitor : IVisitor
    {
        public void Visit(OfficeBuilding building)
        {
            var state = building.ElectricitySystemId > 1000 ? "Good" : "Bad";
            Console.WriteLine($"Main electric shield in building {building.BuildingName} is in {state} state.");
        }

        public void Visit(Floor floor)
        {
            Console.WriteLine($"Diagnostic electricity on floor {floor.FloorNumber}.");
        }

        public void Visit(Room room)
        {
            Console.WriteLine($"Diagnostic electricity in room {room.RoomNumber}.");
        }
    }
}
