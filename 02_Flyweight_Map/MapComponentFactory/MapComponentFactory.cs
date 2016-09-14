namespace _02_Flyweight_Map
{
    public class MapComponentFactory
    {
        private LazyConcurrentDictionary<Trees, IMapComponent> _trees =
            new LazyConcurrentDictionary<Trees, IMapComponent>();
        private LazyConcurrentDictionary<Roads, IMapComponent> _roads =
            new LazyConcurrentDictionary<Roads, IMapComponent>();

        private MapComponentFactory() { }

        public static MapComponentFactory Instance => Nested.instance;
        public int TotalTrees => _trees.Count;
        public int TotalRoads => _roads.Count;

        public IMapComponent CreateTree(Trees treeType) =>
            _trees.GetOrAdd(treeType, key => new MapTreeFlyweight { Title = key.ToString() });
        public IMapComponent CreateRoad(Roads roadType) =>
            _roads.GetOrAdd(roadType, ket => new MapRoadFlyweight { Title = ket.ToString() });
        public IMapComponent CreateHouse(string title) =>
            new MapHouse { Title = title };

        private class Nested
        {
            static Nested() { }
            internal static readonly MapComponentFactory instance = new MapComponentFactory();
        }
    }
}
