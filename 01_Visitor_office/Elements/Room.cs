using _01_Visitor_office.Visitor;

namespace _01_Visitor_office.Elements
{
    public class Room : IElement
    {
        public int RoomNumber { get; set; }

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}