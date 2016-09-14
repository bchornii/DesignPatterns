namespace _02_Flyweight_Map
{
    public interface IMapComponent
    {
        IMapComponent Parent { get; set; }
        string Title { get; set; }
        void Draw(int x, int y);
        IMapComponent FindChild(string name);
    }
}
