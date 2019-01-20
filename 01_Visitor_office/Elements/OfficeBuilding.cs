using System.Collections.Generic;
using _01_Visitor_office.Visitor;

namespace _01_Visitor_office.Elements
{
    public class OfficeBuilding : IElement
    {
        private readonly IList<Floor> _floors = new List<Floor>();
        public string BuildingName { get; set; }
        public int ElectricitySystemId { get; set; }
        public IEnumerable<Floor> Floors => _floors;

        public void AddFloor(Floor floor)
        {
            _floors.Add(floor);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var floor in _floors)
            {
                floor.Accept(visitor);
            }
        }
    }
}
