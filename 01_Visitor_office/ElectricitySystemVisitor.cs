using System;

namespace _01_Visitor_office
{
    public class ElectricitySystemVisitor : IVisitor
    {
        public void VisitOffice(OfficeBuilding building)
        {
            var state = building.ElectricitySystemId > 1000 ? "Good" : "Bad";
            Console.WriteLine($"Main electric shield in building {building.BuildingName} is in {state} state.");
        }

        public void VisitFloor(Floor floor)
        {
            Console.WriteLine($"Diagnostic electricity on floor {floor.FloorNumber}.");
        }

        public void VisitRoom(Room room)
        {
            Console.WriteLine($"Diagnostic electricity in room {room.RoomNumber}.");
        }
    }
}
