namespace _02_Flyweight_Map
{
    public interface IMapComposite : IMapComponent
    {
        void AddComponent(IMapComponent component, int x, int y);
    }
}
