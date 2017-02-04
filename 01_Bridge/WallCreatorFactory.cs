namespace _01_Bridge
{
    public class WallCreatorFactory
    {
        public static WallCreatorFactory Instance { get; }
        protected WallCreatorFactory() { }
        static WallCreatorFactory()
        {
            Instance = new WallCreatorFactory();
        }
        public IWallCreator GetWallCreator()
        {
            if (Config.WallCreator == WallCreatorType.Brick)
            {
                return new BrickWallCreator();
            }
            return new StabWallCreator();;
        }
    }
}