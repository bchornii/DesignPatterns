namespace _02_Flyweight_Map
{
    public abstract class CityBuilder : IMapBuilder
    {
        public IMapComposite Component { get; protected set; }

        protected CityBuilder(string title)
        {
            Component = new MapComposite { Title = title };
        }
        public abstract CityBuilder BuildDistrict(IMapComponent component);
    }

    public class SmallCityBuilder : CityBuilder
    {
        public SmallCityBuilder(string title) : base(title) { }

        public override CityBuilder BuildDistrict(IMapComponent component)
        {
            Component.AddComponent(component, 0, 0);
            return this;
        }
    }
}
