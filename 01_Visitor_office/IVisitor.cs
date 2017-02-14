namespace _01_Visitor_office
{
    public interface IVisitor
    {
        void VisitOffice(OfficeBuilding building);
        void VisitFloor(Floor floor);
        void VisitRoom(Room room);        
    }
}