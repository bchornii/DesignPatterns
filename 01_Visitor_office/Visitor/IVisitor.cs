using _01_Visitor_office.Elements;

namespace _01_Visitor_office.Visitor
{
    public interface IVisitor
    {
        void Visit(OfficeBuilding building);
        void Visit(Floor floor);
        void Visit(Room room);        
    }
}