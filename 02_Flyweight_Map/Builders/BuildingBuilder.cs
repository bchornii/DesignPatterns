namespace _02_Flyweight_Map
{
    public abstract class BuildingBuilder : IMapBuilder
    {
        public IMapComposite Component { get; protected set; }
        protected FlyweightComponentFactory MapFactory { get; }

        protected BuildingBuilder(FlyweightComponentFactory factory, string title) 
        {
            Component = new MapComposite { Title = title };
            MapFactory = factory;
        }        
        public abstract BuildingBuilder BuildHouse(int x, int y);        
    }

    public class HouseBuilder : BuildingBuilder
    {
        public HouseBuilder(FlyweightComponentFactory factory, string title) : 
            base(factory, title) { }

        public override BuildingBuilder BuildHouse(int x, int y)
        {
            Component.AddComponent(MapFactory.CreateHouse(Component.Title), x, y);
            return this;
        }
    }
}
