using System.Collections.Generic;
using System.Linq;

namespace _01_Visitor_office
{
    public class Floor : IElement
    {
        private readonly IList<Room> _rooms = new List<Room>();

        public int FloorNumber { get; }
        public IEnumerable<Room> Rooms => _rooms;

        public Floor(int floorNumber)
        {
            FloorNumber = floorNumber;
        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var room in _rooms)
            {
                room.Accept(visitor);
            }
        }
    }
}