namespace _02_Flyweight_Map
{
    public abstract class RoadBuilder : IMapBuilder
    {
        public IMapComposite Component { get; protected set; }
        protected FlyweightComponentFactory MapFactory { get; private set; }

        protected RoadBuilder(FlyweightComponentFactory factory, string title)             
        {
            Component = new MapComposite { Title = title };
            MapFactory = factory;
        }
        public abstract RoadBuilder BuildDirect(int x, int y);
        public abstract RoadBuilder BuildTurnLeft(int x, int y);
        public abstract RoadBuilder BuildTurnRight(int x, int y);
    }

    public class HighwayBuilder : RoadBuilder
    {
        public HighwayBuilder(FlyweightComponentFactory factory, string title) : 
            base(factory, title) { }

        public override RoadBuilder BuildDirect(int x, int y)
        {
            Component.AddComponent(MapFactory.CreateRoad(Roads.Direct), x, y);
            return this;
        }            

        public override RoadBuilder BuildTurnLeft(int x, int y)
        {
            Component.AddComponent(MapFactory.CreateRoad(Roads.TurnLeft), x, y);
            return this;
        }

        public override RoadBuilder BuildTurnRight(int x, int y)
        {
            Component.AddComponent(MapFactory.CreateRoad(Roads.TurnRight), x, y);
            return this;
        }
    }
}
