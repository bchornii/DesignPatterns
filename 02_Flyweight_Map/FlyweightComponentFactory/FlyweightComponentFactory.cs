namespace _02_Flyweight_Map
{
    public class FlyweightComponentFactory
    {
        private readonly LazyConcurrentDictionary<Trees, IMapComponent> _trees =
            new LazyConcurrentDictionary<Trees, IMapComponent>();
        private readonly LazyConcurrentDictionary<Roads, IMapComponent> _roads =
            new LazyConcurrentDictionary<Roads, IMapComponent>();

        private FlyweightComponentFactory() { }

        public static FlyweightComponentFactory Instance => Nested.instance;
        public int TotalTrees => _trees.Count;
        public int TotalRoads => _roads.Count;

        public IMapComponent CreateTree(Trees treeType) =>
            _trees.GetOrAdd(treeType, key => new MapTreeFlyweight { Title = key.ToString() });
        public IMapComponent CreateRoad(Roads roadType) =>
            _roads.GetOrAdd(roadType, key => new MapRoadFlyweight { Title = key.ToString() });
        public IMapComponent CreateHouse(string title) =>
            new MapHouseFlyweight { Title = title };

        private class Nested
        {
            static Nested() { }
            internal static readonly FlyweightComponentFactory instance = new FlyweightComponentFactory();
        }
    }
}
