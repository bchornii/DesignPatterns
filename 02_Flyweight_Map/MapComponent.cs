namespace _02_Flyweight_Map
{
    public abstract class MapComponent : IMapComponent
    {
        public IMapComponent Parent { get; set; }
        public string Title { get; set; }

        public abstract void Draw(int x, int y);        
        public virtual IMapComponent FindChild(string name) =>
            Title == name ? this : null;
    }
}
