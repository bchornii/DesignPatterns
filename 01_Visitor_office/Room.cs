namespace _01_Visitor_office
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
            visitor.VisitRoom(this);
        }
    }
}