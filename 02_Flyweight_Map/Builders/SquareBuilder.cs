namespace _02_Flyweight_Map
{
    public abstract class SquareBuilder : IMapBuilder
    {
        public IMapComposite Component { get; protected set; }
        protected FlyweightComponentFactory MapFactory { get; private set; }

        protected SquareBuilder(FlyweightComponentFactory factory, string title)             
        {
            Component = new MapComposite { Title = title };
            MapFactory = factory;
        }
        public abstract SquareBuilder BuildAspenTree(int x, int y);
        public abstract SquareBuilder BuildOakTree(int x, int y);        
    }

    public class ParkBuilder : SquareBuilder
    {
        public ParkBuilder(FlyweightComponentFactory factory, string title) : 
            base(factory, title) { }

        public override SquareBuilder BuildAspenTree(int x, int y)
        {
            Component.AddComponent(MapFactory.CreateTree(Trees.Aspen), x, y);
            return this;
        }

        public override SquareBuilder BuildOakTree(int x, int y)
        {
            Component.AddComponent(MapFactory.CreateTree(Trees.Oak), x, y);
            return this;
        }
    }
}
