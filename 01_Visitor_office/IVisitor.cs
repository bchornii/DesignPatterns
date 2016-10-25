namespace _01_Visitor_office
{
    public interface IVisitor
    {
        void Visit(OfficeBuilding building);
        void Visit(Floor floor);
        void Visit(Room room);        
    }
}