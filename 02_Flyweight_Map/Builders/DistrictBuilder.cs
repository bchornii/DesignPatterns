namespace _02_Flyweight_Map
{
    public abstract class DistrictBuilder : IMapBuilder
    {
        public IMapComposite Component { get; protected set; }

        protected DistrictBuilder(string title)
        {
            Component = new MapComposite { Title = title };
        }
        public abstract DistrictBuilder BuildPark(IMapComponent component);
        public abstract DistrictBuilder BuildRoad(IMapComponent component);
        public abstract DistrictBuilder BuildHouseArea(IMapComponent component);
    }

    public class SmallDistrictBuilder : DistrictBuilder
    {
        public SmallDistrictBuilder(string title) : base(title) { }

        public override DistrictBuilder BuildHouseArea(IMapComponent component)
        {
            Component.AddComponent(component, 0, 0);
            return this;
        }

        public override DistrictBuilder BuildPark(IMapComponent component)
        {
            Component.AddComponent(component, 0, 0);
            return this;
        }

        public override DistrictBuilder BuildRoad(IMapComponent component)
        {
            Component.AddComponent(component, 0, 0);
            return this;
        }
    }
}
