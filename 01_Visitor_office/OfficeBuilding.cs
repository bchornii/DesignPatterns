using System.Collections.Generic;

namespace _01_Visitor_office
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
            visitor.VisitOffice(this);
            foreach (var floor in _floors)
            {
                floor.Accept(visitor);
            }
        }
    }
}
